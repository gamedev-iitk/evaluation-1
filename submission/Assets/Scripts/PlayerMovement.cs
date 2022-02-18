using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{Vector3 m_Movement;//Global
//variables part of class are set to a default value eg- m_Movement is given a default value(0,0,0) for Quaternion it is a zero vector
//hence we cgange it to a no rotation vector
Quaternion m_Rotation=Quaternion.identity;
Animator m_Animator;
Rigidbody m_Rigidbody;
public float turnSpeed=30f;
AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator=GetComponent<Animator> ();//GetComponent is a method of mono behaviour hence we do not need to use class
        m_Rigidbody=GetComponent<Rigidbody> ();
        m_AudioSource=GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal=Input.GetAxis("Horizontal");
        float vertical=Input.GetAxis("Vertical");
        m_Movement.Set(horizontal,0f,vertical);
        m_Movement.Normalize();
        bool hasHorizontalInput=!Mathf.Approximately(horizontal,0f);//if there is horizontal input the  it is not )f hence returns false..to make it true we use ! 
        bool hasVerticalInput=!Mathf.Approximately(vertical,0f);
        bool isWalking=hasHorizontalInput || hasVerticalInput;//if either is true then walking .
        m_Animator.SetBool("IsWalking",isWalking);
        if(isWalking)
        { if(!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }

        }
        else{
            m_AudioSource.Stop();
        }
        Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        m_Rotation=Quaternion.LookRotation(desiredForward);
        
    }
     void OnAnimatorMove() {
        m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement * m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MoveRotation(m_Rotation);
    }
}
