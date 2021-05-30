using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public float camChangeDuration = 2f;
    public float endScreenDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public AudioSource exitAudio;
    public CanvasGroup caughtBackgroundImageCanvasGroup;
    public AudioSource caughtAudio;
    public GameObject cam;
    public GameObject endScreen;
    bool m_IsPlayerAtExit;
    bool m_IsPlayerCaught;
    float m_Timer;
    bool m_HasAudioPlayed;

    void OnTriggerEnter (Collider other)
    {
         if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
            cam.SetActive(true);
        }
    }

    public void CaughtPlayer ()
    {
        m_IsPlayerCaught = true;
    }
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(m_IsPlayerAtExit)
        {
            EndLevel (exitBackgroundImageCanvasGroup, false, exitAudio);
        }
        else if(m_IsPlayerCaught)
        {
            EndLevel (caughtBackgroundImageCanvasGroup, true, caughtAudio);
        }
    }

    void EndLevel (CanvasGroup imageCanvasGroup, bool doRestart, AudioSource audioSource)
    {
        if(!doRestart) cam.SetActive(true);
        m_Timer += Time.deltaTime;
        
        if(m_Timer > camChangeDuration)
        {
            if(!m_HasAudioPlayed)
            {
                audioSource.Play();
                m_HasAudioPlayed = true;
            }
            imageCanvasGroup.alpha = (m_Timer - 2) / fadeDuration;
        }

        if(m_Timer > fadeDuration + displayImageDuration + camChangeDuration)
        {
            if (doRestart)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                endScreen.SetActive(true);
                if(m_Timer > fadeDuration + displayImageDuration + camChangeDuration + endScreenDuration)
                    Application.Quit ();
                
            }
        }
    }
}
