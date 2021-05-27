using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    // Start is called before the first frame update
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    bool m_IsPlayerAtExit;
    float m_Timer;
    bool m_HasAudioPlayed;
    public CanvasGroup caughtBackgroundImageCanvasGroup;
    public AudioSource caughtAudio;
    bool m_IsPlayerCaught;

    public CanvasGroup exitBackgroundImageCanvasGroup;
    public AudioSource exitAudio;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }

    }
    public void CaughtPlayer()
    {
        m_IsPlayerCaught = true;
    }
    void EndLevel(CanvasGroup imageCanvasGroup, bool doRestart, AudioSource audioSource)
    {
        if (doRestart == false)
        {
            if (coincounter.scor != 0)
            {
                m_IsPlayerAtExit = false;
                return;
            }
           
                
        }
        if (!m_HasAudioPlayed)
        {
            audioSource.Play();
            m_HasAudioPlayed = true;
        }

        m_Timer += Time.deltaTime;
        imageCanvasGroup.alpha = m_Timer / fadeDuration;
        if (m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
            Debug.Log("ended");
        }

        if (doRestart)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            Application.Quit();
        }
    }
    void Update()
    {
       

        if (m_IsPlayerAtExit)
        {
            EndLevel(exitBackgroundImageCanvasGroup, false, exitAudio);
        }
        else if (m_IsPlayerCaught)
        {
            EndLevel(caughtBackgroundImageCanvasGroup,true,caughtAudio);
        }
    }
}
