using System;
using UnityEngine;

public class CameraFollowMain : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5f;
    public float horizontalLimit = 9f;
    public float offset = 3f;
 
    private float highestY;
 
    void Start(){
        highestY = target.position.y;
        transform.position = new Vector3 (transform.position.x, highestY, transform.position.z);
    }
    void LateUpdate(){
        if (target.position.x > horizontalLimit){
            target.position = new Vector3(-horizontalLimit, target.position.y, target.position.z);
        }
        else if (target.position.x < -horizontalLimit){
            target.position = new Vector3(horizontalLimit, target.position.y, target.position.z);
        }
        if (target.position.y > highestY){
            highestY = target.position.y;
        }
        Vector3 highPoint = new Vector3 (transform.position.x, highestY - offset, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, highPoint, smoothSpeed * Time.deltaTime);
    }
}