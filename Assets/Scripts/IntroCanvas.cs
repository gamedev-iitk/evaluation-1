using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCanvas : MonoBehaviour
{
    public CanvasGroup Intro;
    public CanvasGroup ScoreBoard;
    public PlayerMovement playerMove;
    float m_Timer = 0f;
    float fadeDuration = 1f;
    int i;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit")||i==1)
        {
            playerMove.Move();
            m_Timer += Time.deltaTime;
            Intro.alpha = 1f - (m_Timer / fadeDuration);
            ScoreBoard.alpha = (m_Timer / fadeDuration);

            i = 1;
        }
    }
}
