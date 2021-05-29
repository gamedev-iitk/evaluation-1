using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PauseResume : MonoBehaviour
{
 
    public GameObject PauseScreen;
    public GameObject PauseButton;
    public GameObject IntroImage;
 
    bool GamePaused;
    bool EnableSlow;
    bool GameStart;

    void Start()
    {
        Time.timeScale = 0f;
        GamePaused = false;
        EnableSlow = false;
        GameStart = false;
    }
 
    void Update()
    {
        if(!GameStart){
            if(Input.GetKeyDown(KeyCode.Space)){
                IntroImage.SetActive(false);
                Time.timeScale = 1f;
                GameStart = true;
            }
        }

        if(!EnableSlow){
            if(Input.GetKeyDown(KeyCode.S)){
                Time.timeScale = 0.5f;
                EnableSlow = true;
            }
        }
        else{
            if(Input.GetKeyDown(KeyCode.S)){
                Time.timeScale = 1f;
                EnableSlow = false;
            }
        }


        if(!GamePaused){
            if(Input.GetKeyDown(KeyCode.P)){
                Time.timeScale = 0f;
                PauseScreen.SetActive(true);
                PauseButton.SetActive(false);
                GamePaused = true;
            }
        }
        else{
            if(Input.GetKeyDown(KeyCode.P)){
                Time.timeScale = 1f;
                PauseScreen.SetActive(false);
                PauseButton.SetActive(true);
                GamePaused = false;
            }
        }
    }
 
    public void PauseGame()
    {
        GamePaused = true;
        PauseScreen.SetActive(true);
        PauseButton.SetActive(false);
    }
 
    public void ResumeGame()
    {
        GamePaused = false;
        PauseScreen.SetActive(false);
        PauseButton.SetActive(true);
    }
}