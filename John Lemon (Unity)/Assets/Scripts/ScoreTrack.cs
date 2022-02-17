using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrack : MonoBehaviour
{
    public Text scoreText;
    public Variables c_Score;

    void Update()
    {
        scoreText.text="Score: " + c_Score.value;
    }
}
