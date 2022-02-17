using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private float coin=0;
    public TextMeshProUGUI textcoins;
    void OnTriggerEnter (Collider other){
       if(other.transform.tag=="Coin"){
           coin++;
           textcoins.text=coin.ToString()+" Coins";
           Destroy(other.gameObject);
       }
   }
}
