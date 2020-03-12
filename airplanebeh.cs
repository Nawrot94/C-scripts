using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airplanebeh : MonoBehaviour
{
    public AudioClip gotRing;
    public Material justring;
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();

    }

    void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.CompareTag("ring"))
        {
            FlyThroughRing(other);
            pointsmanager.points += pointsPerRing;

        }
    }

    void FlyThroughRing(Collider ring)
    {
        ring.gameObject.tag = "justring";
        

    
       
        source.PlayOneShot(gotRing);
    }
 }

