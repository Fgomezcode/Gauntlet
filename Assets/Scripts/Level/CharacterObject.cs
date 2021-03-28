using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterClass",menuName = "Character/Player")]
public class CharacterObject : ScriptableObject
{
    
    [Header ("Character Info")]
    [Space]
    public string charName = "Add Character Namer ex. Warrior, Wizard, Ranger";

    [TextArea]
    public string description = "Add Character Info Here";                           

    [Space]
    [Header("Basic Movement and Health Stats")]

    [Tooltip("Default movespeed.")]
    [Range(0f,10f)]
    public float moveSpeed;

    [Space]
    [Header("Max Starting Health")]

    [Tooltip("Used to set starting health.")]
    public float Health;
   

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
    [Header ("Projectile Prefabs")]
    public GameObject projectileCollisionPrefab;
    public GameObject projectilePrefab;  
    [Space]
    [Header("Projectile Stats")]
    public float projectileSpeed;
    public float projectileLife;                               
    public float projectileReload;                            
    public float projectileTimer;
   
}
