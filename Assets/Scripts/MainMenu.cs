using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayeGame()
    {
        SceneManager.LoadScene("MainScene");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
