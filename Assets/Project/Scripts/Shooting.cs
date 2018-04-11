using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    Rigidbody rb;
    public float speed;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        //bullet = GameObject.FindGameObjectWithTag("Bullet");
    }
	
	
	void Update ()
    {
        Fire();
	}

    void Fire()
    {
        if(Input.GetButton("Fire1"))
        {
            GameObject clone = Instantiate(bullet, new Vector3(transform.position.x, 
                transform.position.y, transform.position.z + 1), Quaternion.identity);

            clone.GetComponent<Rigidbody>().velocity = (transform.forward * speed);
       }
    }
}
