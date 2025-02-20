using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuParallax : MonoBehaviour
{
    public float offsetMultiplier = 1f;
    public float smoothTime = .8f;
    
    private Vector2 startPosition2D;
    //private Vector2 startPosition;
    private Vector3 velocity;
    private float startZ;
 
    private void Start()
    {
        startPosition2D = transform.position;
        startZ=transform.position.z;
        //startPosition = transform.position;
    }
 
    private void Update()
    {
        Vector2 offset = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //transform.position = Vector3.SmoothDamp(transform.position, startPosition + (offset * offsetMultiplier), ref velocity, smoothTime);
        Vector3 targetPosition = new Vector3(
            startPosition2D.x + (offset.x*offsetMultiplier),
            startPosition2D.y + (offset.y*offsetMultiplier),
            startZ);

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
