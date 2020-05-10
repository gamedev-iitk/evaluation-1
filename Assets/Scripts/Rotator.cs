using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotator : MonoBehaviour
{
  
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
    }
}
