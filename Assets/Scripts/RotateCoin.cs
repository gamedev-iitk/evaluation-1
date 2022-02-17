using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(0,4,0,Space.World);
    }
}
