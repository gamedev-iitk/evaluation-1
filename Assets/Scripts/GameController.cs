using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    
    void Start()
    {
        gameOverPanel.SetActive(false);
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
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
