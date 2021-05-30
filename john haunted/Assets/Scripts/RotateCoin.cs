using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float m_RotateSpeed;
    
    void Update()
    {
        transform.Rotate(0,m_RotateSpeed*Time.deltaTime,0,Space.World);
    }
}
