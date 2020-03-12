using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    public GameObject ring;
    public int distanceAhead;
    public float screenBorder;
    public float ringSpeed;
    public float minDelay;
    public float maxDelay;
    

    float timer;
    Vector3 spawnPosition;
    GameObject playerPlane;

    void Start()
    {
        timer = Random.Range(minDelay, maxDelay);
        playerPlane = GameObject.Find("Plane1");
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            SpawnRing();
            timer = Random.Range(minDelay, maxDelay);
        }
    }

    void SpawnRing()
    {
        spawnPosition = playerPlane.transform.position;
        spawnPosition.z += distanceAhead;
        spawnPosition.x = Random.Range(-screenBorder, screenBorder);
        GameObject ringObject = (GameObject)Instantiate(ring, spawnPosition, ring.transform.rotation);
        ringObject.GetComponent<Ring>().speed = ringSpeed;
        

      

    }

   

}
