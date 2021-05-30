using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCamera : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject player;
    bool m_IsPlayerAtExit;

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }
       void FixedUpdate()
    {
            // cam1.SetActive(true);
        if(m_IsPlayerAtExit)
        {
            cam3.SetActive(true);
            cam2.SetActive(false);
            cam1.SetActive(false);

            float horizontal = Input.GetAxis("Vertical");
            float vertical = -Input.GetAxis("Horizontal");
        }
        
    }
}
