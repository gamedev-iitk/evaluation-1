using UnityEngine;
public class Obstacle_mov : MonoBehaviour
{   public Rigidbody rb;
    public float out_location;
    public Vector3 go_Location;
    public float forward_acc;
    public Vector3 vel;
    void Start(){
        rb.velocity = vel;
    }
    void FixedUpdate()
    {   
        int rand_index = (Random.Range(-2,3))*3;
        rb.AddForce(0,0,-forward_acc*Time.deltaTime,ForceMode.Acceleration);
        if(transform.position.z<=out_location){
            go_Location.x=rand_index;
            transform.position = go_Location;
            Score.sc++;
        }
    }
    
    
}
