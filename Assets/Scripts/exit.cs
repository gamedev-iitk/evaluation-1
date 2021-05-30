using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class exit : MonoBehaviour
{
   public float fadeDuration = 1f;
   public GameObject player;
   public CanvasGroup exitImage;
   public CanvasGroup CaughtImage;
   bool m_triggered;
   bool m_IsCaught;
   float m_timer;

   void OnTriggerEnter (Collider other)
   {
       if(other.gameObject == player){
            m_triggered = true;
       }
   }

    public void CaughtPlayer()
    {
        m_IsCaught= true;
    }

   void Update()
   {
       if(m_triggered)
       {
            EndLevel(exitImage, false);
       }
       if(m_IsCaught)
       {
           EndLevel(CaughtImage, true);
       }
   }
   void EndLevel(CanvasGroup imageCanvasGroup, bool do_reStart)
   {
        m_timer += Time.deltaTime;
        imageCanvasGroup.alpha = m_timer/fadeDuration;
        if(m_timer > fadeDuration + 1f)
        {
            if(do_reStart)
            {
                SceneManager.LoadScene(0);
            }
            else Application.Quit();
        }
   }
  
}
