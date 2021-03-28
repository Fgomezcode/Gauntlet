using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int MAXPLAYERS = 1;
    public int playerCount;
    public int enemyCount;
    public int maxEnemies;
    public int currentScore;
    public int highScore;

    public int maxKeys;
    public int maxMana;
    public int maxHealth;

    public int numberKeys;
    public int numberMana;
    public int numberHealth;
    [Range(1,100)]
    public int currentLevel;



    private void Start()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel",1);
        currentScore = PlayerPrefs.GetInt("playerScore", 0);
    }


    private void OnApplicationQuit()
    {
       PlayerPrefs.DeleteAll();
    }


}
