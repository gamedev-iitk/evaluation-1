using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject player;
    public GameHandler Gh;
    public GameObject destcoin;
    void start(){
        Gh = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            Gh.coins++;
            Destroy(destcoin);
        }
    }
    void Update(){
        transform.Rotate(0,90*Time.deltaTime,0);
    }

}
