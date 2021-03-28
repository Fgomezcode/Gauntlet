using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        var player = collision.gameObject.GetComponent<PlayerInventory>();
        if (player && player.playerKeys > 0)
        {
            player.playerKeys--;
            Destroy(gameObject, 0.1f);
        }
    }
}
