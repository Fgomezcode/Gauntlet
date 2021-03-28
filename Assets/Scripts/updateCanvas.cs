using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateCanvas : MonoBehaviour
{
    public Text enemyCount;
    public Text playerHealth;
    public Text playerScore;
    public Text currentLevel;


    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject mana1;
    public GameObject mana2;
    public GameObject mana3;

    GameController gameController;
    PlayerSpawn playerStats;
    

   // PlayerInventory playerItems;

    int formatHealth;
    // Start is called before the first frame update
    void Start()
    {
        key1.SetActive(false);
        key2.SetActive(false);
        key3.SetActive(false);
        mana1.SetActive(false);
        mana2.SetActive(false);
        mana3.SetActive(false);
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        formatHealth = Mathf.RoundToInt(playerStats.Health);
        enemyCount.text = gameController.enemyCount.ToString();
        playerHealth.text = formatHealth.ToString();
        playerScore.text = gameController.currentScore.ToString();
        currentLevel.text = PlayerPrefs.GetInt("currentLevel",1).ToString();
    }
}
