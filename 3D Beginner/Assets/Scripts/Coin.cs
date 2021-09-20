using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    public Transform player;
    public GameObject myScore;

    AudioSource m_AudioSource;
    MeshRenderer m_MeshRenderer;

    public float angularVelocity = 100f;
    float y_Tilt = 0f;
    float x_Tilt = 90f;
    float z_Tilt = 0f;
    
    float m_Timer = 0f;

    private Score myScoreScript;
    private float timeToPlay = 1f;
    bool hasCollected = false;

    void Start() {
        myScoreScript = myScore.GetComponent<Score>();
        m_MeshRenderer = GetComponent<MeshRenderer>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        if(other.transform == player) {
            destroyCoin();
        }
    }

    void FixedUpdate()
    {
        z_Tilt += Time.deltaTime*angularVelocity;
        Quaternion target = Quaternion.Euler(x_Tilt, y_Tilt, z_Tilt);

        transform.rotation = target;
    }

    void destroyCoin() {
        m_MeshRenderer.enabled = false;

        if(!hasCollected) {
            myScoreScript.coinCollected();
            m_AudioSource.Play();
            hasCollected = true;
        }
        
        m_Timer += Time.deltaTime;
        if(m_Timer > timeToPlay)
            Destroy(gameObject);
    }
}
