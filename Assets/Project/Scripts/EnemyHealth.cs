using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamageable
{
    public float startH;
    float currentH;
	
	void Start ()
    {
        currentH = startH;
	}
    public float applyDamage(float amount)
    {
        currentH -= amount;


        if(currentH <= 0.0f)
        {
            Destroy(gameObject);
        }
        return 0;
    }
}
