using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItem : MonoBehaviour
{
    public GameObject Pmovement;
    public int coins = 0;

    public Text CoinCounter;
    public Text SprintCounter;

    public float SprintDuration;

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift) && SprintDuration > 0)
        {
            Pmovement.GetComponent<PlayerMovement>().speed = 2;
            SprintDuration -= Time.deltaTime;
        }
        else if(!Input.GetKey(KeyCode.LeftShift) || SprintDuration  <= 0)
        {
            Pmovement.GetComponent<PlayerMovement>().speed = 1;
        }

        CoinCounter.text = string.Format("Coins : {0}", coins);
        SprintCounter.text = string.Format("Sprint Duration left : {0}", (int)SprintDuration);
    }
}
