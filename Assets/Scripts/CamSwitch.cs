using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

  
       void FixedUpdate()
    {
            // cam1.SetActive(true);
        
        if(Input.GetKey(KeyCode.V))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        else if(Input.GetKey(KeyCode.C))
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
        }
    }
}
