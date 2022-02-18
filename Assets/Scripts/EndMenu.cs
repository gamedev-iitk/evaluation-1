using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void PlayAgain () 
    {
        SceneManager.LoadScene("MainScene");
    }

    public void StartMenu ()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void QuitButton ()
    {
        Application.Quit();
    }
}
