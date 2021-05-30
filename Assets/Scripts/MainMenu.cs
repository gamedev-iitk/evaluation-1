using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public int index;
    [SerializeField] int maxIndex;
    public void PlayGame()
    {
        /* if (index < maxIndex)
         {
             index++;
         }
         else
         {
             index = 0;
         }*/
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
