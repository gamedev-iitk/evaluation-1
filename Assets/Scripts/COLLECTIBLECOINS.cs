using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COLLECTIBLECOINS : MonoBehaviour
{public int GoldCoin;
    // Start is called before the first frame update
    void Start()
    {
        
    }
public void OnTriggerEnter(Collider Col)
{
    if(Col.gameObject.tag=="GoldCoins")
    {
        Debug.Log("Coins collected");
        GoldCoin=GoldCoin+1;
        Col.gameObject.SetActive(false);
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
