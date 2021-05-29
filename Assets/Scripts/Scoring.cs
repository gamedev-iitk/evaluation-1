using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    public int score;
    void OnTriggerEnter(Collider other)
    {
        score += 1;
        Destroy(gameObject);
        Debug.Log(score);
    }
}
