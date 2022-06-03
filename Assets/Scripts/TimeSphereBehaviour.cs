using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSphereBehaviour : MonoBehaviour
{
    
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == Player.transform)
        {   

            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
