using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NoOfCoins : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Text>().text  = "Coins Collected: 0";
    }

    public void UpdateText(int CoinsCollected) 
    {
        gameObject.GetComponent<Text>().text  = "Coins Collected: " + CoinsCollected.ToString();
    }
}
