using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player_Movement movement;

    void OnCollisionEnter(Collision cInfo)
    {
        if(cInfo.collider.tag == "obstacle")
        {
           movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
   
}
