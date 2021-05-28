using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sanity : MonoBehaviour
{
    bool m_IsNearGhost;
    public Transform player;
    public PlayerMovement play;
    public GameEnding gameEnding;
    public float effect;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_IsNearGhost = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            m_IsNearGhost = false;
        }
    }

    void Update()
    {
        if(play.sanity<=0) gameEnding.LowSanity();
        if (m_IsNearGhost)
        {
            play.sanity -= Convert.ToInt32(Time.deltaTime * effect);
        }
    }
}
