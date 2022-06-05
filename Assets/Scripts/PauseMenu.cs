using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject pauseMenu;
   
   
   
      void Update()
    {
            if (Input.GetKeyDown(KeyCode.Escape))
            {    
                 if(isGamePaused)
             {
                     ResumeGame();
             }
             else 
             {
                    PauseGame();
             }
            }

    }


    // Start is called before the first frame update
   
   
   void PauseGame()
    {
         pauseMenu.SetActive(true);
         Time.timeScale = 0f;
         isGamePaused = true;
    }
   

    public void ResumeGame()
    {
         pauseMenu.SetActive(false);
         Time.timeScale = 1f;
         isGamePaused = false;
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    
}