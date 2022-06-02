using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeUpdate : MonoBehaviour
{
    public float timer;
    public Text TEXT;
    public GameObject[] Sphere;
    bool m_istrue1 = false;
    bool m_istrue2 = false;
    bool m_istrue3 = false;  
    bool m_istrue4 = false;
    bool m_istrue5 = false;

    public GameEnding gameEnding;
    public CanvasGroup caughtBackgroundImageCanvasGroup;
    public AudioSource caughtAudio;


    public void Start()
    {
        TEXT.text = timer.ToString("0");
    }
       
        void Update()
    {
        timer = timer - Time.deltaTime;
        TEXT.text = timer.ToString("0");

        if(Sphere[0] == null && m_istrue1 == false )
        {
            timer += 5f;
            m_istrue1 = true;
        }

        if (Sphere[1] == null && m_istrue2 == false)
        {
            timer += 5f;
            m_istrue2 = true;
        }

        if (Sphere[2] == null && m_istrue3 == false)
        {
            timer += 5f;
            m_istrue3 = true;
        }

        if (Sphere[3] == null && m_istrue4 == false)
        {
            timer += 5f;
            m_istrue4 = true;
        }

        if (Sphere[4] == null && m_istrue5 == false)
        {
            timer += 5f;
            m_istrue5 = true;
        }

        if (timer <= 0f)
        {
            
            gameEnding.EndLevel(caughtBackgroundImageCanvasGroup, true, caughtAudio);
        }

    }
    
}