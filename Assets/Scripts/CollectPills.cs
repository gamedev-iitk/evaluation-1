using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPills : MonoBehaviour
{
    private PlayerMovement player;
    public GameObject Player;
    public GameEnding gameEnding;
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            if (player.sanity < 100)
            {
                if (player.sanity + 20 <= 100) player.sanity += 20;
                else player.sanity = 100;
            }
            Destroy(gameObject);
            gameEnding.pillAudio.Play();
        }
    }
}
