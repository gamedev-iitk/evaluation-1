using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class collectcoins : MonoBehaviour
{

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            other.GetComponent<PlayerMovement>().points++;
            Destroy(gameObject);
        }
    }

}
