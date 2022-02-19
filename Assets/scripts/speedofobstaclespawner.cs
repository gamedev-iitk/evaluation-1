using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedofobstaclespawner : MonoBehaviour
{
    public Rigidbody os;
    public float forforce = 0.001f;
    void FixedUpdate()
    {
        os.velocity = new Vector3(0,0,forforce*Time.deltaTime);
    }
}
