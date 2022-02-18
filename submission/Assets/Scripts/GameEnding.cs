using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public GameObject scoreT;
    public GameObject highscoreT;
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup; 
    public AudioSource exitAudio;
    public CanvasGroup caughtBackgroundImageCanvasGroup;
    public AudioSource caughtAudio;
    bool m_IsPlayerAtExit;
    bool m_IsPlayerCaught;
    float m_Timer;
    bool m_HasAudioPlayed;
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
        if (m_IsPlayerAtExit)
        {
            EndLevel (exitBackgroundImageCanvasGroup, false,exitAudio);
        }
        else if (m_IsPlayerCaught)
        {
            EndLevel (caughtBackgroundImageCanvasGroup, true,caughtAudio);
        }
    }

    void EndLevel (CanvasGroup imageCanvasGroup, bool doRestart,AudioSource audioSource)
    {
        if(!m_HasAudioPlayed)
        {
            audioSource.Play();
            m_HasAudioPlayed=true;
        }
        m_Timer += Time.deltaTime;
        imageCanvasGroup.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            if (doRestart)
            {
                SceneManager.LoadScene (0);
                if(CollectCoin.score>CollectCoin.highscore)
            {CollectCoin.highscore=CollectCoin.score;
            highscoreT.GetComponent<Text>().text="HIGHSCORE: " + CollectCoin.highscore;
            }
                scoreT.GetComponent<Text>().text="SCORE: "+0;
                CollectCoin.score=0;
                }
            else
            {
            highscoreT.GetComponent<Text>().text="HIGHSCORE: "+CollectCoin.score;
                CollectCoin.score=0;
                Application.Quit ();
            }
        }
    }
}
