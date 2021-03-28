using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{

   //------ SAME STATS AS THE CHARACTER CLASS --------------//

    [Header("Character Info")]
    [Space]
    public string charName;
    [TextArea]
    public string description;
    [Space]
    [Header("Basic Movement and Health Stats")]
    [Tooltip("Default movespeed.")]
    [Range(0f, 10f)]
    public float moveSpeed;
    [Space]
    [Header("Max Starting Health")]
    [Tooltip("Used to set starting health.")]
    public float Health;
    public float  MAXHEALTH = 1000;
    [Space]
    [Header("Damage Stats")]
    [Tooltip("Starting Damage.")]
    public float baseDamage;
    [Tooltip("Damage done to enemy if they collide with player.")]
    public float collisionDamge;
    [Space]
    [Header("Sprite References")]
    public Sprite characterArtWork;
    public Sprite projectileArtWork;
    [Space]
    [Header("Projectile Prefabs")]
    public GameObject projectileCollisionPrefab;
    public GameObject projectilePrefab;
    [Space]
    [Header("Projectile Stats")]
    public float projectileSpeed;
    public float projectileLife;
    public float projectileReload;
    public float projectileTimer;

    //------------------------------//
    CharacterObject characterClass;
    SpriteRenderer playerSprite;

    private void Awake()
    {
        // FIND AND REF THE CHARACTER CLASS  //
        characterClass = GetComponent<CharacterClass>().charStats;

        playerSprite = GetComponent<SpriteRenderer>();
        applyStats();
    }

    public void applyStats()
    {
        charName = characterClass.charName;
        description = characterClass.charName;
        moveSpeed = characterClass.moveSpeed;
        Health = PlayerPrefs.GetFloat("playerHealth",MAXHEALTH); ;
       
        baseDamage = characterClass.baseDamage;
        collisionDamge = characterClass.collisionDamge;

        playerSprite.sprite = characterClass.characterArtWork;
        projectileArtWork = characterClass.projectileArtWork;

        projectileCollisionPrefab = characterClass.projectileCollisionPrefab;
        projectilePrefab = characterClass.projectilePrefab;
        projectileSpeed = characterClass.projectileSpeed;
        projectileLife = characterClass.projectileLife;
        projectileReload = characterClass.projectileReload;
        projectileTimer = characterClass.projectileTimer;
    }


}
