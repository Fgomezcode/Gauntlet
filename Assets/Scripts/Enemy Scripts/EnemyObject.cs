using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "EnemyClass", menuName = "Enemy/New")]
public class EnemyObject : ScriptableObject
{
    public string enemyName;
    public string enemyDescription;

    public float moveSpeed;
    public float boostedMoveSpeed;
    public int maxHealth;
    
    public int baseDamage;
    

    public Sprite enemyArtWork;
    public Sprite enemyProjectileArtWork;

    public GameObject enemyProjectilePrefab;
    public float enemyProjectileSpeed;
    public float enemyProjectileLife;
    public float enemyProjectileReload;
    public float enemyProjectileTimer;

    public bool isRangedEnemy = false;

 
}
