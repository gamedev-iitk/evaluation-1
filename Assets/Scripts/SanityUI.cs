using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityUI : MonoBehaviour
{
    Text sanity;
    public PlayerMovement player;
    void Start()
    {
        sanity = GetComponent<Text>();
    }

    void Update()
    {
        sanity.text = "Sanity: " + player.sanity+"%";
    }
}
