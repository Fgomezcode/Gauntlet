using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class SpriteController : MonoBehaviour
{

    /// <summary>
    /// Flip sprite around depending on mouse and movement position
    /// </summary>
    PlayerMovement playerMovement;
    SpriteRenderer playerSprite;
    GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playerSprite = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        flip();
    }


    public void flip()
    {
        if (playerMovement.movement.x < 0)
        {
            playerSprite.flipX = true;
        }
        else if (playerMovement.movement.x > 0)
        {
            playerSprite.flipX = false;
        }
        else
        {
            mouseFlip();
        }
    }

    public void mouseFlip()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(mousePosition.x < player.transform.position.x )
        {
            playerSprite.flipX = true;
            
        }
        else if(mousePosition.x > player.transform.position.x)
        {
            playerSprite.flipX = false;
        }


    }

}
