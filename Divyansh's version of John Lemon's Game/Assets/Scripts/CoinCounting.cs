using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounting : MonoBehaviour
{
    
    public int m_NoOfCoins;
    public NoOfCoins coinsScript;
    void Start()
    {
        m_NoOfCoins = 0;
    }

    public void IncrementCoins(){
        m_NoOfCoins += 1;
        coinsScript.UpdateText(CoinsCollected());
    }

    public int CoinsCollected(){
        return m_NoOfCoins;
    }

}
