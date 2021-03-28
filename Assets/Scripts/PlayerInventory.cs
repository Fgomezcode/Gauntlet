using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    updateCanvas canvas;
    public int playerKeys;
    public int playerMana;

    void Start()
    {
       // playerKeys = PlayerPrefs.GetInt("playerKeys", 0);
       //playerMana = PlayerPrefs.GetInt("playerMana", 0);
        canvas = FindObjectOfType<Canvas>().GetComponent<updateCanvas>();
    }

    void Update()
    {
        updateInventory();  
    }

    public void updateInventory()
    {
        // keys
        if (playerKeys == 1)
        {
            canvas.key1.SetActive(true);
            canvas.key2.SetActive(false);
            canvas.key3.SetActive(false);
        }
        else if (playerKeys == 2)
        {
            canvas.key1.SetActive(true);
            canvas.key2.SetActive(true);
            canvas.key3.SetActive(false);
        }
        else if (playerKeys == 3)
        {
            canvas.key1.SetActive(true);
            canvas.key2.SetActive(true);
            canvas.key3.SetActive(true);
        }
        else if (playerKeys == 0)
        {
            canvas.key1.SetActive(false);
            canvas.key2.SetActive(false);
            canvas.key3.SetActive(false);
        }

        // mana 
        if (playerMana == 1)
        {
            canvas.mana1.SetActive(true);
            canvas.mana2.SetActive(false);
            canvas.mana3.SetActive(false);
        }
        else if (playerMana == 2)
        {
            canvas.mana1.SetActive(true);
            canvas.mana2.SetActive(true);
            canvas.mana3.SetActive(false);
        }
        else if (playerMana == 3)
        {
            canvas.mana1.SetActive(true);
            canvas.mana2.SetActive(true);
            canvas.mana3.SetActive(true);
        }
        else if (playerMana == 0)
        {
            canvas.mana1.SetActive(false);
            canvas.mana2.SetActive(false);
            canvas.mana3.SetActive(false);
        }

        // keep mana and keys in range
        if (playerMana < 0)
        {
            playerMana = 0;
        }
        if (playerMana > 3)
        {
            playerMana = 3;
        }

        if (playerKeys < 0)
        {
            playerKeys = 0;
        }
        if (playerKeys > 3)
        {
            playerKeys = 3;
        }
    }





}
