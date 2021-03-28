using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileChangeCollisionSprite : MonoBehaviour
{
    CharacterObject classStats;
    SpriteRenderer collisionSprite;

    


    public void Awake()
    {
       
        classStats = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterClass>().charStats;
        collisionSprite = GetComponent<SpriteRenderer>();
        
       

       // collisionSprite.sprite = classStats.projectileCollisionArtWork;
    }


}
