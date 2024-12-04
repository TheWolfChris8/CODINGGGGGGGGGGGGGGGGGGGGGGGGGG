using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatedParalax : MonoBehaviour
{
    //Declaring Variables needed
    private float length, startPos;
    public GameObject cam;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        //Getting the x value of start position
        startPos = transform.position.x;
        //getting the length of the sprite
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //how far we have moved from our starting position
        float dist = (cam.transform.position.x * parallaxEffect);
        //move sprite based on cam position
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

        //moving the background based on how far we have traveled. Changing the start position
        //tells us how far we have moved relative to the camera
        float temp = (cam.transform.position.x * (1 - parallaxEffect));

        if(temp > startPos + length){
            startPos += length; // startPos = startPos + length
        }else if(temp < startPos - length){
            startPos -= length; // startPos = startPos - length
        }
    }
}
