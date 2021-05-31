using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Transform player;
    Transform trans;
    public GameEnding gameEnding;
    public PlayerMovement playerMove;
    bool m_IsPlayerInRange;

    void OnTriggerEnter(Collider other)
    {
        if(other.transform == player)
        {
            m_IsPlayerInRange = true;
        }
    }
    void Start()
    {
        trans = GetComponent<Transform>();
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.transform == player)
        {
            m_IsPlayerInRange = false;
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        if (m_IsPlayerInRange)
        {
            Vector3 direction = player.position - trans.position + Vector3.up;
            Ray ray = new Ray(trans.position, direction);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray,out raycastHit))//this will tell whether the raycast hit somthing and set the raycst variabe to the name of the object being hit
            {
                if (raycastHit.collider.transform == player)
                {
                    playerMove.Stop();
                    gameEnding.CaughtPlayer();
                }
            }

        }
    }
}
