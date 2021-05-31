using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 20f;
    public bool shouldStop = true;
    bool Switch;
    float horizontal;
    float vertical;
    float temp;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;//a way to store rotations and identity is the defult value
    Animator m_Animator;
    Rigidbody m_Rigidody;
    AudioSource m_FootSteps;
    
    // Start is called before the first frame update
    void Start()
    {
        
        m_Animator = GetComponent<Animator>();
        //get component lets in a component to this script
        m_Rigidody = GetComponent<Rigidbody>();
        //here m_Animator is working like a pointer in C but for a whole script
        m_FootSteps = GetComponent<AudioSource>();
        //footstep audio component connected to the player
    }

    public void Stop()
    {
        shouldStop = true;
    }
    public void Move()
    {
        shouldStop = false;
    }
    public void Orignal()
    {
        Switch = false;
    }

    public void SwitchAxis()
    {
        Switch = true;
    }
    void Update(){
        
        //check is shift is pressed
        if(Input.GetButtonDown("Fire3")==true){
            m_Animator.SetBool("IsShiftDown",true);                 
        }
        if(Input.GetButtonUp("Fire3")){
        m_Animator.SetBool("IsShiftDown",false);
        }
        if (!shouldStop)
        {
            if (!Switch)
            {
                horizontal = Input.GetAxis("Horizontal");
                vertical = Input.GetAxis("Vertical");
            }
            else
            {
                vertical = -(Input.GetAxis("Horizontal"));
                horizontal = (Input.GetAxis("Vertical"));
            }
        }
        

    }

    void FixedUpdate()
    {
        
        m_Movement.Set(horizontal,0f,vertical);//defines a vector
        m_Movement.Normalize ();
        //makes the magnitude of the vector == 1
        bool hasHorizontalInput = !Mathf.Approximately (horizontal,0f); //if horizontal is not approx 0 then true [!]
        bool hasVerticalInput = !Mathf.Approximately (vertical,0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput; // will set the bool to 1 if either of the input is true

        if (!shouldStop)
        {
            m_Animator.SetBool("IsWalking", isWalking);//connecting link b\w this script and animator
        }
        else
        {
            m_Animator.SetBool("IsWalking", false);
        }
        

        if (isWalking)//check whether player is moving
        {
            if (!m_FootSteps.isPlaying)//whether the audio is playing
            {
                m_FootSteps.Play();
            }
        }
        else
        {
            m_FootSteps.Stop();
        }
        Vector3 desiredForward = Vector3.RotateTowards (transform.forward,m_Movement,turnSpeed * Time.deltaTime, 0f);//delta time is the time taken by the next frame to load
        m_Rotation = Quaternion.LookRotation (desiredForward);
        
    }

    void OnAnimatorMove ()
    {
        //deltaPosition is the change in the root position
        if (shouldStop)
        {
            m_Movement.Set(0f, 0f, 0f);//the the movment vector a null vector
        }
        
        m_Rigidody.MovePosition (m_Rigidody.position + m_Movement*m_Animator.deltaPosition.magnitude);
        m_Rigidody.MoveRotation (m_Rotation);//using rotation vector to rotate

    }

}
