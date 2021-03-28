using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    private Transform player;
    Vector2 startingPosition;

    public EnemyObject enemyStats;
   
    public float distanceTolerance;
    public float moveSpeed;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        startingPosition = new Vector2(transform.position.x, transform.position.y);

        enemyStats = gameObject.GetComponent<EnemyClassHolder>().enemyClass;
        moveSpeed = enemyStats.moveSpeed;
    }



    private void FixedUpdate()
    {

        followPlayer();

    }

    void followPlayer()
    {
        if(Vector2.Distance(transform.position, player.position) < distanceTolerance )
        {

            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, startingPosition, moveSpeed * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, player.position, 0 * Time.deltaTime);
        }

    }



   

}
