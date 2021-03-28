using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    GameController gameController;
    PlayerSpawn currentStats;
    PlayerInventory playerItems;

    public int currentLevel;
    public float currentHealth;
    public int numberKeys;
    public int numberMana;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        currentStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSpawn>();
        playerItems = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
        
        currentLevel = gameController.currentLevel;

       // currentHealth = currentStats.Health;

        numberKeys = playerItems.playerKeys;
        numberMana = playerItems.playerKeys;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.tag == "Player";

        if(player)
        {
            loadLevel();
        }
        
    }
    void loadLevel()
    {
        currentLevel++;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("currentLevel", currentLevel);
        PlayerPrefs.SetFloat("playerHealth", currentStats.Health);
        PlayerPrefs.SetInt("playerScore", gameController.currentScore);

        clearInventory();

    }

    void clearInventory()
    {
        playerItems.playerKeys = 0;
        playerItems.playerMana = 0;
    }





}
