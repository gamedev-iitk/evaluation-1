using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStars : MonoBehaviour
{

    public AudioSource collectSound;
      void OnTriggerEnter (Collider Other){
        collectSound.Play();
        ScoringSystem.theScore += 1;
        
        Destroy(gameObject);
    }
        
    }

