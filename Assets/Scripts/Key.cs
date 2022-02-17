using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject player;
    public ScoreAndKey scoreAndKey;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject == player)
        {
            scoreAndKey.keyCollected();
            Destroy(this.gameObject);
        }
    }
}
