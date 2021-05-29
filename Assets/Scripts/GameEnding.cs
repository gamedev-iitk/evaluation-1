using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    bool m_IsPlayerAtExit;
    public float fadeDuration = 1f;
    public float displayImageDuration=1f;
    public GameObject player;
    public AudioSource exitAudio;
    public AudioSource caughtAudio;
    float m_Timer=0;
    bool m_HasAudioPlayed;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public CanvasGroup caughtBackgroundImageCanvasGroup;
    bool m_IsPlayerCaught;
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("YO");
        if(other.gameObject == player)
        {
            m_IsPlayerAtExit=true;
        }
    }
    public void CaughtPlayer()
    {
        m_IsPlayerCaught=true;
    }
    void Update()
    {
        if(m_IsPlayerAtExit)
        {
            EndLevel(exitBackgroundImageCanvasGroup, false,exitAudio);
        }
        else if(m_IsPlayerCaught)
        {
            EndLevel(caughtBackgroundImageCanvasGroup, true, caughtAudio);
        }
    }
    void EndLevel(CanvasGroup imageCanvasGroup, bool doRestart, AudioSource audioSource)
    {
        if(!m_HasAudioPlayed)
        {
            audioSource.Play();
            m_HasAudioPlayed=true;
        }
        m_Timer+=Time.deltaTime;
        imageCanvasGroup.alpha=m_Timer/fadeDuration;
        if(m_Timer>fadeDuration+displayImageDuration)
        {
            if(doRestart)
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
