using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollectCoins : MonoBehaviour
{
    Text coinCountdisplay;
    public static int coinCount;

    void Start()
    {
        coinCountdisplay = GetComponent<Text>();
        coinCountdisplay.text = "0";

    }

    // Update is called once per frame
    void Update()
    {
      coinCountdisplay.text = coinCount.ToString() ;
    }

}
