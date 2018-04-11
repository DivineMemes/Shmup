using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damage;
    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            IDamageable d = other.gameObject.GetComponent<IDamageable>();
            d.applyDamage(damage);
        }
    }
}
