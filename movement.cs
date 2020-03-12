using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float flyingSpeed;
    public float horizontalFlyingSpeed;
    public float maxAngle = 300;
    

    

    Vector3 planePosition;
    Vector3 currentRotation;
    Vector3 destinationRotation;

    void Start()
    {
        planePosition = transform.position;
        currentRotation = transform.eulerAngles;
    
    }

    void Update()
    {
        planePosition = transform.position;

        planePosition.x += Input.acceleration.x * horizontalFlyingSpeed * Time.deltaTime;
        planePosition.x = Mathf.Clamp(planePosition.x, -4.7f, 4.7f);
        transform.position = planePosition;

        destinationRotation = new Vector3(0, 0, Input.acceleration.x * maxAngle);

        currentRotation = new Vector3(-90, 0, Mathf.LerpAngle(currentRotation.z, destinationRotation.z, Time.deltaTime));

        transform.eulerAngles = currentRotation;

        //transform.Translate(transform.forward * Time.deltaTime * flyingSpeed);

}

}
