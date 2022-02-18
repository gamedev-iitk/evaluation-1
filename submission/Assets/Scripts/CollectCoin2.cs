using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin2 : MonoBehaviour
{public AudioSource collectSound;
   void OnTriggerEnter(Collider other) {
        collectSound.Play();
       CollectCoin.score+=20;
        Destroy(gameObject);
    }
}
