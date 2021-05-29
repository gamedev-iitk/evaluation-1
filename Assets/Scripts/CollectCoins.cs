using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public GameObject player; 

    

    public AudioSource collectAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter (Collider other){
        if(other.gameObject == player){
            Destroy(gameObject);
            other.GetComponent<PlayerCollect>().points++;
            collectAudio.Play();
        }
    }

    
}
