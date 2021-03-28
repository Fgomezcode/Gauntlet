using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKey : MonoBehaviour
{
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerInventory>();
        if (player)
        {
            player.playerKeys++;
            Destroy(gameObject, 0.1f);
            PlayerPrefs.SetInt("playerKeys",player.playerKeys);
        }
    }
}
