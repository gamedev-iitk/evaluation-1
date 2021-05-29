using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController1 : MonoBehaviour
{
    public GameObject youWonPanel;

    void Start()
    {
        youWonPanel .SetActive(false);
    }
    public void youWon()
    {
        youWonPanel . SetActive(true);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");
    }
    public void Exit()
    {
        Application.Quit();
        
    }
}
