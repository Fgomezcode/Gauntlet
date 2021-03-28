using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    PlayerSpawn playerStats;
    
   

    // Start is called before the first frame update
    void Start()
    {
        playerStats = GetComponent<PlayerSpawn>();
    }

    private void Update()
    {
        playerStats.Health -= Time.deltaTime;
        if (playerStats.Health > 1000)
        {
            playerStats.Health = 1000;
            
        }
        if (playerStats.Health <= 0 )
        {
            //Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<EnemySpawn>();
        
        if (enemy)
        {
            playerTakeHit(enemy.baseDamage);
            Debug.Log("you were hit");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<HealthPickUp>();
        
        if (health)
        {
            playerHeal(health.healAmount);
        }
        else if(!health)
        {
            Debug.Log("you walked over something");
        }
    }

    public void playerTakeHit(float damage)
    {
        playerStats.Health -= damage;
        if(playerStats.Health <= 0)
        {
            Destroy(gameObject.GetComponent<PlayerMovement>());
        }
    }

    public void playerHeal(float healAmount)
    {
        if(playerStats.Health >=  1000)
        {
            playerStats.Health = 1000;
            Debug.Log("ALREADY AT FULL HEALTH");
        }
        else
        {
            playerStats.Health += healAmount;
            Debug.Log("HEAL 100");
        }
    }

    
}
