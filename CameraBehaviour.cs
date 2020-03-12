using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    Vector3 offset;
    Vector3 cameraPos;
    GameObject Plane1;

    void Start()
    {
        Plane1 = GameObject.FindWithTag("Plane");
        offset = Camera.main.transform.position - Plane1.transform.position;
        cameraPos = Camera.main.transform.position;
    }

    void Update()
    {
        cameraPos.z = Plane1.transform.position.z + offset.z;
        Camera.main.transform.position = cameraPos;
    }
}
