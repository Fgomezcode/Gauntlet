using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerToFollow;

    Transform target;
    public Vector3 offset;

    [Range(0.5f,10f)]
    public float cameraSmoothing;

    private void Start()
    {
        playerToFollow = GameObject.FindGameObjectWithTag("Player");
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        cameraDelay();
    }

    void cameraDelay()
    {
       Vector3 targetPosition = target.position + offset;
       Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, cameraSmoothing * Time.fixedDeltaTime);
       transform.position = smoothPosition;
    }
}
