using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelItemSpawner : MonoBehaviour
{
    public GameObject[] itemArray;
    GameController gameController;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        spawnItems();
    }


    void spawnItems()
    {
        if (gameController.numberKeys < gameController.maxKeys)
        {
            spawnKey();
        }
        else if (gameController.numberMana < gameController.maxMana)
        {
            spawnMana();
        }
        else if (gameController.numberHealth < gameController.maxHealth)
        {
            spawnHealth();
        }
        else
        {
            Destroy(gameObject, 1f);
        }

        Destroy(gameObject, 3f);
    }


    void spawnKey()
    {
        Instantiate(itemArray[0], transform.position, Quaternion.identity);
        gameController.numberKeys++;
    }

    void spawnMana()
    {
        Instantiate(itemArray[1], transform.position, Quaternion.identity);
        gameController.numberMana++;  
    }

    void spawnHealth()
    {
        Instantiate(itemArray[2], transform.position, Quaternion.identity);
        gameController.numberHealth++;
    }

}
