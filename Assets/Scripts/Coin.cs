using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject player;
    public ScoreAndKey scoreAndKey;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject == player)
        {
            scoreAndKey.coinCollected();
            Destroy(this.gameObject);
        }
    }
}
