using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coincounter : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI myscore;
    public static int scor;
    private void Start()
    {
        myscore = GetComponent<TextMeshProUGUI>();
        scor = 3;
        myscore.text = "3";
    }
    private void Update()
    {
        myscore.text = scor.ToString();
    }
}
