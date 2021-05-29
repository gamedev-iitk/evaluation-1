using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public GameObject player;
    public GameObject timer;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public CanvasGroup caughtBackgroundImageCanvasGroup;
    public AudioSource exitAudio;
    public AudioSource caughtAudio;
    public GameController gameController;
    public GameController1 gameController1;
    public GameController2 gameController2;
   

    bool m_IsPlayerAtExit;
    float m_Timer;                                              //we need this to ensure that game doesn't end before the fade finsihes out
    bool m_IsPlayerCaught;
    public float displayImageDuration = 1f;             // to display the images for a brief moment and then finish fading.
    bool m_HasAudioPlayed;
    bool m_IsTimeUp;
    public int count = 0;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject==player)
        {
            m_IsPlayerAtExit = true;
        }

    }
    public void CaughtPlayer()
    {
        m_IsPlayerCaught = true;
    }
    public void TimeUp()
    {
        m_IsTimeUp = true;
    }
    public void Hit()
    {
        count += 1;
    }
    void Update()
    {
        if(m_IsPlayerAtExit)
        {
            Endlevel(exitBackgroundImageCanvasGroup, false, exitAudio);
            //gameController.GameOver();
        }
        else if(m_IsPlayerCaught)
        {
           
            Endlevel(caughtBackgroundImageCanvasGroup, true, caughtAudio);
            //System.Threading.Thread.Sleep(2000);
            //gameController.GameOver();
        }
        else if(m_IsTimeUp)
        {
            if (!m_HasAudioPlayed)
            {
                caughtAudio.Play();
                m_HasAudioPlayed = true;
            }
            gameController2.timeUp();
        }
    void Endlevel(CanvasGroup imageCanvasGroup, bool doRestart, AudioSource audioSource) //this method needs to fade the canvas group and quit the game
        {
            

            if (!m_HasAudioPlayed)
            {
                audioSource.Play();
                m_HasAudioPlayed = true;
            }
            m_Timer += Time.deltaTime;
            imageCanvasGroup . alpha = m_Timer / fadeDuration;
            

            if (m_Timer > fadeDuration + displayImageDuration)
            {
                imageCanvasGroup.alpha = 0;
                
                
                if (doRestart)
                {
                    gameController.GameOver();
                    timer.SetActive(false);
                    //SceneManager.LoadScene(0);

                }
                else
                {
                    gameController1.youWon();
                    timer.SetActive(false);
                    //Application.Quit();
                }
            }
            }

    }
}
