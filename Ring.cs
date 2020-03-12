using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public float speed;
    

    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);

        if (transform.position.z < -7)
            Destroy(this.gameObject);
    }
}
