using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    public CanvasGroup caughtBackgroundImageCanvasGroup;
    public AudioSource caughtAudio;
    public GameObject player;
    public GameObject finish;
 

    public bool m_IsPlayerAtExit;
    public Text timerText;
    float time = 120;
    bool Val = true;
    float m_Timer;
    bool m_HasAudioPlayed;
    string Value;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    void Update()
    {
        if (time < 0)
        {
            Val = false;  
        }
        if (m_IsPlayerAtExit)
        {
            Val = false;

        }
        if (Val)
        {
            time -= Time.deltaTime;
            Value = time.ToString("f0");

            timerText.text ="Your Score " +Value;
        }
        else
        {
            timerText.text ="Your Score "+ Value;
            
        }
        if (time < 0)
        {
            EndLevel(caughtBackgroundImageCanvasGroup, caughtAudio);
        }
    }

    

    

    void EndLevel(CanvasGroup imageCanvasGroup, AudioSource audioSource)
    {
        if (!m_HasAudioPlayed)
        {
            audioSource.Play();
            m_HasAudioPlayed = true;
        }

        m_Timer += Time.deltaTime;
        imageCanvasGroup.alpha = m_Timer / 2f;

        if (m_Timer > 2f + 2f)
        {
            
            SceneManager.LoadScene(0);
           
        }
    }

}

