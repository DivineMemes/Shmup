using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody rb;
    public float speed;
    Vector3 forwardDir;
    Vector3 rightDir;

    Vector3 Pos;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Debug.Log((forwardDir + rightDir) * speed);
        //rb.AddForce((forwardDir + rightDir) * speed );
        rb.MovePosition(transform.position + (forwardDir + rightDir) * speed);
    }

    void Update()
    {
        Pos = transform.position;
        Pos.x = Mathf.Clamp(transform.position.x, -17.0f, 17.0f);

        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        forwardDir = transform.forward * vert;
        rightDir = transform.right * horz;

        transform.position = Pos;

        //Debug.Log(horz + " " + vert);
        //GetComponent<Rigidbody>().MovePosition(transform.position + dirVector * Time.deltaTime);



    }
}
