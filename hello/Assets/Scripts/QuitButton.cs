using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void doquit()
    {
        // #if UNITY_EDITOR //
        //     UnityEditor.EditorApplication.isPlaying = false;
        // #else
            Debug.Log("quit");
            Application.Quit();
            
        // #endif
    }
}
