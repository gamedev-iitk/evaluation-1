using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerCount : MonoBehaviour
{
    public GameEnding gameEnding;
    public GameObject timer;
    float currentTime;
    float startingTime = 75f;

    public Text CountdownTime;

    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownTime.text = currentTime.ToString("0");
        if(currentTime<=10)
        {
            CountdownTime.color = Color.red;
        }
        if(currentTime<=0)
        {
            currentTime = 0;
            gameEnding.TimeUp();
            timer.SetActive(false);
    
        }
    }

}
