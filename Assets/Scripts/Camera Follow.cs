using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //allows us to target a specific game object to track its transform values
    public Transform target;

    //creating a new Vector 3 t offset the camera from the player position
    public Vector3 offset = new Vector3(0, 2, -10);

    public float smoothTime = 0.25f;

    Vector3 currentVelocity;

    // Update is called once per frame
    void LateUpdate()
    {
        //transforming the position of the camera using the SmoothDamp method, it needs the current postition of the object, where it needs to go, current velocity, and how long it should take to get to location
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref currentVelocity, smoothTime);
    }
}
