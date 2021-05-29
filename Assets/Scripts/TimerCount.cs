using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCount : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsleft=100;
    public bool takingAway=false;
    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text=secondsleft + " seconds remaining";
    }

    // Update is called once per frame
    void Update()
    {
        if(takingAway==false && secondsleft>0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingAway=true;
        yield return new WaitForSeconds(1);
        secondsleft-=1;
        if(secondsleft>=10)
        {
            textDisplay.GetComponent<Text>().text=secondsleft + " seconds remaining";
        }
        else
        {
            textDisplay.GetComponent<Text>().text="0"+secondsleft + " seconds remaining";
        }
        takingAway=false;
    }
}
