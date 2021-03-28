using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    CharacterObject classStats;
    float projectileLife = 0;
    float projectileTimer = 0;

    void Start()
    {
        classStats = FindObjectOfType<CharacterClass>().charStats;
        projectileLife = classStats.projectileLife;
        
    }

   
    void Update()
    {
       if(gameObject.tag == "PlayerProjectile")
        {
            projectileTimer += Time.deltaTime;

            if(projectileTimer >= projectileLife)
            {
              Destroy(gameObject);
            
            }
        }


       if(gameObject.tag == "ProjectileCollision")
        {
            Destroy(gameObject, 0.2f);
        }

    }
}
