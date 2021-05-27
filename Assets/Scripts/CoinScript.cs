using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.GetComponent<PlayerItem>().coins += 1;
            player.GetComponent<PlayerItem>().SprintDuration += 2;
            Destroy(gameObject);
        }
    }
}
