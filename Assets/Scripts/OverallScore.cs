using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallScore : MonoBehaviour
{
   public AudioSource collectSound;
   private void OnTriggerEnter(Collider other)
    {
	collectSound.Play();
        CoinTrophyMeter.TrophyCount += 1;
        Destroy(gameObject);

}

}
