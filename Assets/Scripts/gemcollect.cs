using UnityEngine;

public class gemcollect : MonoBehaviour
{   
    public GameObject player;
    public PlayerMovement playerMovement;
    void OnTriggerEnter(Collider other){
        if(other.gameObject==player){
            GetComponent<Renderer>().enabled=false;
            playerMovement.gemcoun();            
        }
    }
}
