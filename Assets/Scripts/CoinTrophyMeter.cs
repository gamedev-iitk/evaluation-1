using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTrophyMeter : MonoBehaviour
{
    public GameObject CoinTrophyText;
    public static int TrophyCount;

    void Update()
    {
        CoinTrophyText.GetComponent<Text>().text = "TROPHIES :" + TrophyCount ;

}
}
