using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total : MonoBehaviour
{
    public static int theScore = 0;
    public GameObject scoreText;
    void Update()
    {
        scoreText.GetComponent<Text>().text = "COINS : " + theScore;
    }
}
