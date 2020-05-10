using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countscript : MonoBehaviour
{
    public int lemons=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        GUI.Label(new Rect(100,100,1000,200),"Lemons Collected : "+lemons);
    }
}
