using UnityEngine;

public class Movement : MonoBehaviour
{   public Rigidbody rb;
    public float sideforce=500f;
    void FixedUpdate()
    {   
        if(Input.GetKey("d")){
            rb.AddForce(sideforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        
    }
}
