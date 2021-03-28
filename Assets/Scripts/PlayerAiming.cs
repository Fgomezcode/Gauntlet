using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAiming : MonoBehaviour
{
    // Rotate firepoint to face mouse.
    
    Transform playerPosition;
    Rigidbody2D firePointBody;
    Vector2 mousePosition;
    Camera mainCamera;

    // Start is called before the first frame update
    void Awake()
    {   playerPosition = GameObject.FindGameObjectWithTag("Player").transform; // follow player position
        
        
        firePointBody = GetComponent<Rigidbody2D>();
        mainCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        firePointBody.transform.position = playerPosition.transform.position;
    }

    private void FixedUpdate()
    {
        Vector2 lookDirection = mousePosition - firePointBody.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        firePointBody.rotation = angle;
    }
}
