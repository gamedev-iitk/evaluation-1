using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Text Cointext;
    public int coins = 0;

    void Update(){
        Cointext.text = " Coins collected : " + coins + " / 10";

    }
}
