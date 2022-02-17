using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAndKey : MonoBehaviour
{
    public Text noOfKeys;
    public Text noOfCoins;
    public GameEnding gameEnding;
    public AudioSource keyCollect;
    public AudioSource coinCollect;
    public AudioSource finalKey;
    int keys = 0;
    int score = 0;

    public void keyCollected()
    {
        keys++;
        keyCollect.Play();
        if(keys == 3)
        {
            finalKey.Play();
            gameEnding.ExitOpened();
        }
    }
    public void coinCollected()
    {
        score++;
        coinCollect.Play();
    }
    void Update()
    {
        noOfKeys.text = "Keys - " + keys;
        noOfCoins.text = "Score - " + score;
    }
}
