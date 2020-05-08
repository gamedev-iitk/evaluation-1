using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

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
        transform.Rotate(90*Time.deltaTime,0,0);
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject==player)
        {
            collectAudio.Play();
            other.GetComponent<Points>().points++;
            Destroy(gameObject);
        }
    }
}
