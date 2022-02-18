using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public Transform player;

    

    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(other.transform != null)
            {
                PlayerCollectCoins.coinCount +=1;
            }
            Destroy(gameObject);
        }
    }
}
