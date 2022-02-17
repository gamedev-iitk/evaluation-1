using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration=1f;
    public GameObject player;

    public CanvasGroup exitBackgroundImageCanvasGroup;
    public AudioSource exitAudio;

    public CanvasGroup caughtBackgroundImageCanvasGroup;
    public AudioSource caughtAudio;

    public CanvasGroup finalScoreImageCanvasGroup;

    public Variables c_Score;
    public Text scoreText;

    bool m_IsPlayerAtExit;
    bool m_IsPlayerCaught;

    float m_Timer;
    bool m_HasAudioPlayed;

    public float displayImageDuration = 1f;

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    public void CaughtPlayer ()
    {
        m_IsPlayerCaught = true;
    }

    void Update ()
    {
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
        if(!m_HasAudioPlayed)
        {
            audioSource.Play();
            m_HasAudioPlayed = true;
        }
        
        m_Timer += Time.deltaTime;

        imageCanvasGroup.alpha = m_Timer / fadeDuration;

        if(m_Timer > fadeDuration + displayImageDuration)
        {
            
            
            if (doRestart)
            {
                SceneManager.LoadScene (0);
                c_Score.value=0;
            }
            else
            {
                Application.Quit ();
                c_Score.value=0;
            }
        }
        
    }

    void DisplayFinalScore()
    {

    }
}
