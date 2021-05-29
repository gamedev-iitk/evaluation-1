using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{   
    Text text;
    public static int CoinAmount;
    void Start()
    {
        text=GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {   
        text.text = CoinAmount.ToString();
    }
}
