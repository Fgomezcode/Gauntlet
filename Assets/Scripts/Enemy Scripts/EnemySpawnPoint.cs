using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    public GameController gameController;
    public GameObject enemyPrefab;
    public int maxEnemies;
   
    public float spawnTimer;
    public float spawnDelay;
    private void Update()
    {
        
        enemySpawn(maxEnemies);
    }
    

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        maxEnemies = gameController.maxEnemies;
    }

    public void enemySpawn(int maxEnemies)
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer >= spawnDelay && gameController.enemyCount < maxEnemies)
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            spawnTimer = 0;

            if(gameController.enemyCount < maxEnemies)
            {
                gameController.enemyCount++;
            }
        }

        if (spawnTimer > 2)
        {
            spawnTimer = 2;
        }
      

    }

 



}
