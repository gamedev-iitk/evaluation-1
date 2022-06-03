using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public float FadeDuration = 1f;
    public GameObject player;

    bool m_IsPlayerAtExit;
    bool m_IsPlayerCaught;
    bool m_HasAudioPlayed;

    public CanvasGroup exitBackgroundImageCanvasGroup;
    public CanvasGroup caughtBackgroundImageCanvasGroup;
    public AudioSource exitAudio;
    public AudioSource caughtAudio;
    public Text TEXT;

    float m_Timer;
    public float displayImageDuration = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
            
        }
    }

    public void CaughtPlayer()
    {
        m_IsPlayerCaught = true;
    }

    private void Update()
    {
        if(m_IsPlayerAtExit)
        {
            EndLevel(exitBackgroundImageCanvasGroup, false, exitAudio);
        }

        else if(m_IsPlayerCaught)
        {    
            EndLevel(caughtBackgroundImageCanvasGroup, true, caughtAudio);
            
        }
    }

    public void EndLevel(CanvasGroup imageCanvasGroup, bool doRestart , AudioSource audiosource)
    {
        TEXT.text = "";
        if (!m_HasAudioPlayed)
        {
            audiosource.Play();
           m_HasAudioPlayed = true;
        }

        m_Timer += Time.deltaTime;
        imageCanvasGroup.alpha = m_Timer / FadeDuration;

        if(m_Timer > FadeDuration + displayImageDuration)
        {
            if (doRestart)
            {
                
                SceneManager.LoadScene(0);
            }
            else
            {
                Application.Quit();
            }
        }
    }

}
