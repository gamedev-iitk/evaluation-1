using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject player;
    void Update(){
        transform.Rotate(90*Time.deltaTime,0,0);
    }
    private void OnTriggerEnter(Collider other){
    if(other.gameObject == player)
    {
        other.GetComponent<Point>().points++;
        Destroy(gameObject);
    }
    }
}
