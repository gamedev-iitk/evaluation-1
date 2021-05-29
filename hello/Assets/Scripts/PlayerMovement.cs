using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 20f;
    float idleTime = 0.4f;
    float timer = 0.0f; 
    public AudioSource m_AudioSource;
    public AudioSource m_CoinCollecter;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;

    void Start ()
    {
        m_Animator = GetComponent<Animator> ();
        m_Rigidbody = GetComponent<Rigidbody> ();
        // m_AudioSource = GetComponent<AudioSource>();
        // m_CoinCollecter = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Coin")
        {   
            ScoreText.CoinAmount += 1000;
            m_CoinCollecter.Play();
            Destroy(other.gameObject);
            
        }

    }
    void OnTriggerExit(Collider other)
    {
        if(other.transform.tag == "Coin")
        {   
            m_CoinCollecter.Stop();
        } 
    }
    void FixedUpdate ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normalize ();

        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        if(isWalking)
        {
            if(!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }
        }
        else
        {
            m_AudioSource.Stop();
        }
        if(!isWalking)
        {   
            
            timer += Time.deltaTime;
            if(timer >= idleTime)
            {
                m_Animator.SetBool("IsWalking",false);
                timer = 0f;
            } else 
            {
                m_Animator.SetBool("IsWalking",true);
                timer = 0f;
            }
        }
        
        m_Animator.SetBool("IsWalking", isWalking);

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation(desiredForward);
    }

    void OnAnimatorMove ()
    {
        m_Rigidbody.MovePosition(m_Rigidbody.position + m_Movement * m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MoveRotation(m_Rotation);
    }
}
