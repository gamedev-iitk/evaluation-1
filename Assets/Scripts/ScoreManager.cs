using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    int score= 0;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text = "Coins: " + score.ToString();
    }

    // Update is called once per frame
 public void AddPoint()
 {
     score +=1;
     scoreText.text = "Coins: " + score.ToString();
 }
}
