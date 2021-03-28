using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    CharacterObject classStats;
    GameObject projectilePrefab;
    GameObject firePoint;

    float projectileSpeed;
 
    private void Awake()
    {
        classStats = FindObjectOfType<CharacterClass>().charStats;
        projectilePrefab = classStats.projectilePrefab;
        projectileSpeed = classStats.projectileSpeed;
        // Assign firepoint
        firePoint = GameObject.FindGameObjectWithTag("FirePoint");

        //set up timer
        classStats.projectileTimer = classStats.projectileReload;
    }
 
    void Update()
    {
        if (Input.GetButtonDown("Fire1") )
        {
            Shoot();
        }
        reloadTimer();
    }

    void Shoot()
    {
        if(classStats.projectileTimer >= classStats.projectileReload)
        {
            GameObject bullet = Instantiate(projectilePrefab, firePoint.transform.position, firePoint.transform.rotation);
            Rigidbody2D bulletBody = bullet.GetComponent<Rigidbody2D>();
            bulletBody.AddForce(firePoint.transform.up * projectileSpeed, ForceMode2D.Impulse);
            classStats.projectileTimer = 0; // set timer to zero and you cant shoot anymore

        }
        

        if(classStats.projectileTimer >= classStats.projectileReload)
        {
            classStats.projectileTimer = classStats.projectileReload;
        }
        
    }

    public void reloadTimer()
    {
        if (classStats.projectileTimer < classStats.projectileReload)
        {
            classStats.projectileTimer += Time.deltaTime;
        }
    }
}
