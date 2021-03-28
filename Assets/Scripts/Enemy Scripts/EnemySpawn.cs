using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    /// <summary>
    /// This script pulls the data from the scriptable object
    /// and stores them as a local variable.
    /// </summary>


    EnemyObject enemyStats;
    SpriteRenderer enemySprite;
    
   
    public float moveSpeed;
    public float boostedMoveSpeed;
    public float health;
    public float baseDamage;

    public int healthDropRate;

    public float enemyProjectileSpeed;
    public float enemyProjectileLife;
    public float enemyProjectileReload;
    public float enemyProjectileTimer;

    public bool isRangedEnemy = false;



    private void Awake()
    {
        enemyStats = GetComponent<EnemyClassHolder>().enemyClass;
        enemySprite = GetComponent<SpriteRenderer>();

        moveSpeed = enemyStats.moveSpeed;
        boostedMoveSpeed = enemyStats.boostedMoveSpeed;
        //health = enemyStats.maxHealth;                   // set health in inspector
        baseDamage = enemyStats.baseDamage;
        

        enemyProjectileSpeed = enemyStats.enemyProjectileSpeed;
        enemyProjectileLife = enemyStats.enemyProjectileLife;
        enemyProjectileReload = enemyStats.enemyProjectileReload;
        enemyProjectileTimer = enemyStats.enemyProjectileTimer;
        enemySprite.sprite = enemyStats.enemyArtWork;
        


    }

    void Update()
    {
        
    }
}
