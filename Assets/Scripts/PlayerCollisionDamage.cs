using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDamage : MonoBehaviour
{
    CharacterClass classStats;
    float collisionDamage;

    // Start is called before the first frame update
    void Awake()
    {
        classStats = GetComponent<CharacterClass>();

        collisionDamage = classStats.charStats.collisionDamge;
        Debug.Log(collisionDamage);
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        var enemy = collision.collider.GetComponent<EnemyHealth>();
        if (enemy)
        {
            enemy.takeHit(collisionDamage);
        }

    }



}
