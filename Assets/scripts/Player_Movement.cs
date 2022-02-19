using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 600f;
    public float sideforce = 500f;
    // Update is called once per frame
    void Update()
    {
       rb.AddForce(0,0,forwardforce*Time.deltaTime); 
       if(Input.GetKey("d")){
           rb.AddForce(sideforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
       }
       if(Input.GetKey("a")){
           rb.AddForce(-sideforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
       }
       if(rb.position.y < -3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
