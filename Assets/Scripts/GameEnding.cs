using UnityEngine;
using UnityEngine.SceneManagement;
public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackground;
    public CanvasGroup caughtBackground;
    public AudioSource exitAudio;
    public AudioSource caughtAudio;
    bool m_IsPlayeratExit;
    float m_Timer;
    bool m_HasAudioPlayed;
    bool m_IsPlayerCaught;
    public int gemcount=0;
    void OnTriggerEnter (Collider other ){
        if (other.gameObject == player){
            m_IsPlayeratExit=true;
        }
    }
     public void CaughtPlayer (){
        m_IsPlayerCaught = true;
    }
    void FixedUpdate(){
        if(m_IsPlayeratExit){
            Endlevel(exitBackground,false,exitAudio);
        }else if(m_IsPlayerCaught){
            Endlevel(caughtBackground,true,caughtAudio);
        }

    }
    void Endlevel(CanvasGroup image, bool doRestart,AudioSource audioSource){
        if (!m_HasAudioPlayed){
            audioSource.Play();
            m_HasAudioPlayed = true;
        }
        m_Timer+=Time.deltaTime;
        image.alpha = m_Timer/fadeDuration;
        if(m_Timer > fadeDuration + displayImageDuration){
            if(!doRestart) Application.Quit();
            else SceneManager.LoadScene(0);
        }
    }
}
