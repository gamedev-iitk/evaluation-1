using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public Transform Player;
    public GameObject camBack;
    public GameObject camFront;
    public GameObject endCam;
    public KeyCode TKey;
    bool m_camSwitch = false;
    bool m_HasCameraChanged = false;
    

    void OnTriggerEnter (Collider other)
    {
         if (other.gameObject == Player)
        {
            Debug.Log("Collided");
            m_HasCameraChanged = true;
        }
    }

    void Update()
    {
        if(!m_HasCameraChanged){
            endCam.SetActive(false);
            if (Input.GetKeyDown(KeyCode.C))
            {
                m_camSwitch = !m_camSwitch;
                camBack.SetActive(m_camSwitch);
                camFront.SetActive(!m_camSwitch);
            }
        }
        else
        {
            endCam.SetActive(m_HasCameraChanged);
        }
    }
}



// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CamSwitch : MonoBehaviour
// {
//     public Transform Player;
//     public GameObject camBack;
//     public GameObject camFront;
//     public KeyCode TKey;
//     bool m_camSwitch = false;
    
//     void Update()
//     {
//         if (Input.GetKeyDown(TKey))
//         {
//             m_camSwitch = !m_camSwitch;
//             camBack.SetActive(m_camSwitch);
//             camFront.SetActive(!m_camSwitch);
//         }
//     }
// }
