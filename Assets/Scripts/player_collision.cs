using UnityEngine;

public class player_collision : MonoBehaviour
{   
    public Movement mov;
    void OnCollisionEnter(Collision colinfo){
        if(colinfo.collider.tag=="Obstacle"){
            mov.enabled=false;
            FindObjectOfType<Game_Over>().EndGame();
        }
    }
}
