using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class ScoringSystem : MonoBehaviour
{
    
    public AudioSource collectSound;
    public Transform player;
  

    
    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            collectSound.Play();
            Total.theScore += 1;
            Destroy(gameObject);
        }
    }
}
