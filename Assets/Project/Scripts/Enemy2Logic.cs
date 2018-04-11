using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Logic : MonoBehaviour
{
    public float speed;
    GameObject player;
    Vector3 dirVec;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        dirVec =  player.transform.position - gameObject.transform.position; 
    }


    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().velocity = (dirVec * speed);
    }
    	
}
