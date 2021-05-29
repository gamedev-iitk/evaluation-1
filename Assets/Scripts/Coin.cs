using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    Text text;
    public static int coinTotal;
    public GameObject player;

    void Start()
    {
        coinTotal = 0;
        text = GetComponent<Text>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            coinTotal += 1;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        text.text = coinTotal.ToString();
    }
}