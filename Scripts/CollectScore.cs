using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScore : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 1;        //Adds up score when a trigger is entered
        Destroy(gameObject);
    }
}
