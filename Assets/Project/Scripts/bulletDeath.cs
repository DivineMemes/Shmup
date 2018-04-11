using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDeath : MonoBehaviour
{
    float timer;
    public float bulletSpan;
	void Start ()
    {
        timer = bulletSpan;
	}
	
	
	void Update ()
    {
        timer -= Time.deltaTime;

        if(timer <= 0.0f)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.layer == 10)
        {
            Destroy(gameObject);
        }
    }
}
