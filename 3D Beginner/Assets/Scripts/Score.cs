using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    int score;

    void Start() {
        score = 0;
    }

    void Update() {
        scoreText.text = "Coins Collected: " + score.ToString() + "/7";
    }

    public void coinCollected() {
        score++;
    }
}
