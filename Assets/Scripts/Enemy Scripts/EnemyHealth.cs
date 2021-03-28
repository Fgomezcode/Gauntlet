using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject healthPickup;
    GameController gameController;
    EnemySpawn spawnStats;
    public float currenthealth;
    int enemyCount;

    [Range(0f,1f)]
    public float dropChance;
    public float dropRate;

    float spawnDps; // potential damage marker;

    private void Awake()
    {

        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        spawnStats = GetComponent<EnemySpawn>();
        currenthealth = spawnStats.health;
        spawnDps = transform.position.y + 1;
        enemyCount = gameController.enemyCount;
        dropChance = Random.Range(0f, 100f);
        dropRate = 0.05f;
    }
    public void Start()
    {
        dropRate = Random.Range(0f, 10f);
    }


    public void takeHit(float damage)
    {
        currenthealth -= damage;
           
        if(currenthealth <= 0 )
        {
            gameController.currentScore +=10;
            enemyDeath();
            Destroy(gameObject);
            if (dropChance < dropRate)
            {
               Instantiate(healthPickup, transform.position, Quaternion.identity);
            }
        }
    }



    public void enemyDeath()
    {
        gameController.enemyCount--;
    }
}
