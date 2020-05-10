using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public int rotateSpeed;
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
