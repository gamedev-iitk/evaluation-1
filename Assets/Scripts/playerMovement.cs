using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float horizontal;
    float vertical;
    Vector3 m_movement;
    bool isWalking;
    bool horizontalInput;
    bool verticalInput;
    Animator m_Animator;
    public float turnSpeed = 20f;
    Quaternion m_rotation = Quaternion.identity;
    Rigidbody m_rigidBody;
    AudioSource m_audioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_rigidBody = GetComponent<Rigidbody>();
        m_audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        m_movement.Set(horizontal, 0f, vertical);
        m_movement.Normalize();

        bool horizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool verticalInput = !Mathf.Approximately(vertical, 0f);
        bool isWalking = verticalInput || horizontalInput;
        m_Animator.SetBool ("iswalk", isWalking);

        Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_movement, turnSpeed * Time.deltaTime, 0f);
        m_rotation = Quaternion.LookRotation(desiredForward);

        if(isWalking)
        {
            if(!m_audioSource.isPlaying)
            {
                m_audioSource.Play();
            }
        }
        else
        {
            m_audioSource.Stop();
        }

    }

    private void OnAnimatorMove() 
    {
        m_rigidBody.MovePosition(m_rigidBody.position + m_movement*m_Animator.deltaPosition.magnitude);
        m_rigidBody.MoveRotation(m_rotation);
    }
}
