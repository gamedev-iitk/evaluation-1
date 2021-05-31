using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    float score = 0f;
    public TMPro.TextMeshProUGUI scoreboard;
    
    public void addScore()
    {
        score += 1;
    }
    void Update() {
       scoreboard.text = score.ToString();
    }
}
