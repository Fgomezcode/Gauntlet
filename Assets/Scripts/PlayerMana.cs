using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerInventory>();
        if (player)
        {
            player.playerMana++;
            Destroy(gameObject, 0.1f);
            PlayerPrefs.SetInt("playerMana", player.playerMana);
        }
        
    }
}
