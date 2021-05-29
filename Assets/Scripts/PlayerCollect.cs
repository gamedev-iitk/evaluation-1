using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public int points = 0;

    

    public GUIStyle guistyle = new GUIStyle();

    public GUIStyle guistyle2 = new GUIStyle();
    
    void OnGUI(){

        guistyle.fontSize = 65;
        guistyle.fontStyle = FontStyle.Bold;
        guistyle.normal.textColor = Color.white;

        

        GUI.Label(new Rect(150,50,200,40), "Score: " + (points * 10),guistyle);

        
    }
}
