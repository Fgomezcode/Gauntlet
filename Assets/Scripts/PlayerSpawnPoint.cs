using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{
    public GameObject player;
    GameController gameController;


    void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        spawnPlayer();
    }


    void spawnPlayer()
    {
        if (gameController.playerCount < gameController.MAXPLAYERS)
        {
            Instantiate(player, transform.position, Quaternion.identity);
            gameController.playerCount++;
        }
        Destroy(gameObject, 1f);
    }


}
