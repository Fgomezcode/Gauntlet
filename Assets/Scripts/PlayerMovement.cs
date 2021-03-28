using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This script is strictly for player movement

    Animator playerAnim;
    CharacterObject classStats;  
    Rigidbody2D playerBody;

   public Vector2 movement;

    
    float moveSpeed;
    

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
        classStats = gameObject.GetComponent<CharacterClass>().charStats;
        playerBody = GetComponent<Rigidbody2D>();
        moveSpeed = classStats.moveSpeed;
        
    }

    //check for key press.
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        SpriteRenderer playerSprite = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();


       /* if (movement.x > 0.2 || movement.x < -0.2)
        {
            playerAnim.Play("dash anim");
        }
        else
        {
            playerAnim.Play("WizardAnim");
        }*/
    }

    private void FixedUpdate()
    {
        playerBody.MovePosition(playerBody.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
