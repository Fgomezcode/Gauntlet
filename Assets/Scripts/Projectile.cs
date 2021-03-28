using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    GameObject collisionPrefab;
    CharacterObject classStats;

    public float baseDamage;
    public float boostedDamage;

    SpriteRenderer projectileSprite;


    private void Awake()
    {
        classStats = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterClass>().charStats;

        collisionPrefab = classStats.projectileCollisionPrefab;
        projectileSprite = gameObject.GetComponent<SpriteRenderer>(); // access sprite renderer

        baseDamage = classStats.baseDamage;
        //boostedDamage = classStats.boostedDamage;
        projectileSprite.sprite = classStats.projectileArtWork;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {

            Destroy(gameObject);
            Instantiate(collisionPrefab, gameObject.transform.position, Quaternion.identity);

        }
        var enemy = collision.collider.GetComponent<EnemyHealth>();
        if (enemy)
        {
            enemy.takeHit(baseDamage);
            Instantiate(collisionPrefab, gameObject.transform.position, Quaternion.identity);
        }

    }

}







