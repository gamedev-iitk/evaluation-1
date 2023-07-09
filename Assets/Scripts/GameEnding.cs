using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public GameObject player;
    bool m_IsPlayerAtExit;
    bool m_IsPlayerCaught;
    bool exitOpened = false;
    public CanvasGroup exitImageBackgroundCanvasGroup;
    public CanvasGroup caughtImageBackgroundCanvasGroup;
    float m_timer = 0f;
    public float imageDuration = 1f;
    public AudioSource exitAudio;
    public AudioSource caughtAudio;
    bool m_HasAudioPlayed;
    public Text noOfKeys;
    public Text collectMoreKeys;
    public Text Coins;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    public void ExitOpened()
    {
        exitOpened = true;
    }
    public void IsCaught()
    {
        m_IsPlayerCaught = true;
    }
    private void Update() 
    {
        if(m_IsPlayerAtExit && exitOpened)
        {
            EndLevel(exitImageBackgroundCanvasGroup, false, exitAudio);
        }   
        else if(m_IsPlayerCaught)
        {
            EndLevel(caughtImageBackgroundCanvasGroup, true, caughtAudio);
        }

        if(m_IsPlayerAtExit && !exitOpened)
        {
            collectMoreKeys.text = "( Collect More Keys )";
        }
    }
    void EndLevel(CanvasGroup imageCanvasGroup, bool doRestart, AudioSource audioSource)
    {
        if(!m_HasAudioPlayed)
        {
            Destroy(noOfKeys);
            Destroy(collectMoreKeys);
            Destroy(Coins);
            audioSource.Play();
            m_HasAudioPlayed = true;
        }
        
        m_timer += Time.deltaTime;
        imageCanvasGroup.alpha = m_timer/fadeDuration;

        if(m_timer > fadeDuration + imageDuration)
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
