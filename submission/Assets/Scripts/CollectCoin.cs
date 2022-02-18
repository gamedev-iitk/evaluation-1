using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{public GameObject scoreText;
    public static int score;
    public static int highscore;
     void Update() {
          scoreText.GetComponent<Text>().text="SCORE: " + score;
     }
}
