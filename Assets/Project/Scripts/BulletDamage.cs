using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public float damage;

    void Start()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.layer == 10)
        {
            IDamageable blah = other.collider.GetComponent<IDamageable>();
            if(blah != null)
            {
                blah.applyDamage(damage);
            }
        }
    }
	
}
