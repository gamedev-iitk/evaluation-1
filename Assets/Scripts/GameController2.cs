using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController2 : MonoBehaviour
{
    public GameObject timeUpPanel;

    void Start()
    {
        timeUpPanel.SetActive(false);
    }
    public void timeUp()
    {
        timeUpPanel.SetActive(true);
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
