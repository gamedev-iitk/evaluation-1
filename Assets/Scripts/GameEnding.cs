using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayDuration = 1f;
    public bool m_IsPlayerAtExit;//when to start fade
    public bool m_IsPlayerCaught;
    float m_Timer = 0f;
    public GameObject player;//reference to gameobject
    public CanvasGroup exitBackgroundCanvasGroup;
    public CanvasGroup caughtBackgroundCanvasGroup;
    public AudioSource exitAudio;
    public AudioSource caughtAudio;
    bool m_HasAudioPlayed;

    
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
    void Update()
    {
        if (m_IsPlayerAtExit)
        {
            EndLevel(exitBackgroundCanvasGroup,false,exitAudio);
            
            

        }
        else if (m_IsPlayerCaught)
        {
            EndLevel(caughtBackgroundCanvasGroup,true,caughtAudio);
        }
    }

    void EndLevel(CanvasGroup imageCanvasGroup,bool doRestart,AudioSource audioSource)
    {
        if (!m_HasAudioPlayed)
        {
            audioSource.Play();
            m_HasAudioPlayed = true;
        }
        m_Timer += Time.deltaTime;
        imageCanvasGroup.alpha = m_Timer / fadeDuration;
        if (m_Timer > fadeDuration + displayDuration)
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
