using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float spawnInterval;
    float timeTillSpawn;

    public GameObject Enemy1;
    public GameObject Enemy2;

	void Start ()
    { 
        spawnInterval = Random.Range(3, 5);
        timeTillSpawn = spawnInterval;
    }
	
	void Update ()
    {
        //timeTillSpawn = spawnInterval + Random.Range(0, 2);
        Spawn();
	}



    void Spawn()
    {
        timeTillSpawn -= Time.deltaTime;
        if(timeTillSpawn <= 0.0f)
        {
            int EnemytoSpawn = Random.Range(0,10);
            
            if(EnemytoSpawn > 1)
            {
                GameObject clone = Instantiate(Enemy1, transform.position, Quaternion.identity);
                clone.GetComponent<Rigidbody>().velocity = (transform.forward * (Random.Range(1, 5) * - 1));
            }
            else
            {
                GameObject clone = Instantiate(Enemy2, transform.position, Quaternion.identity);
                clone.GetComponent<Rigidbody>().velocity = (transform.forward * (Random.Range(1, 5) * -1));
            }



            spawnInterval = Random.Range(3, 5);
            timeTillSpawn = spawnInterval + Random.Range(0,2);

        }
    }
}
