using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public GameObject player;
    public CoinCounting totalCoins;

    public AudioSource m_audioSource;

    void OnTriggerEnter(Collider other){
        if(other.gameObject == player){
            gameObject.SetActive(false);
            m_audioSource.Play();
            totalCoins.IncrementCoins();
        }
    }

}
