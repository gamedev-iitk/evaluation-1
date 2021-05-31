using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{

    public Score score;
    public GameObject plr;
    public AudioSource collect;
    bool play = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == plr)
        {
            score.addScore();
            play = true;
            
        }
    }
    private void Update()
    {
        
        if (play)
        {
            collect.Play();
            Destroy(gameObject);
        }
    }

}
