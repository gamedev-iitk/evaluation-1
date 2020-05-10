using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour {

    // Start is called before the first frame update
    Text tex;
     public static int coinAmount;
    void Start()
    {
        tex = GetComponent<Text>();
    }
    void Update()
    {
        tex.text = coinAmount.ToString();
    }


}
