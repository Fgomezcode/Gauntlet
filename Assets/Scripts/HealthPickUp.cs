using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    public int healAmount;

    public void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.tag == "Player")
        { 
            Destroy(gameObject,0.3f);
        }

    }
}
