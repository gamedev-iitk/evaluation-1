using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        CoinCount.coinAmount += 1;
        Destroy(gameObject);
    }


}