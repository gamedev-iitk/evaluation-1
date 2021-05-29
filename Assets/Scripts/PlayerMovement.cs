using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    AudioSource m_AudioSource;
    public Text gemscore;
    public float turnSpeed=20f;
    bool Sprint = false;
    int gemcout = 0;
    public CanvasGroup init;
    bool tart=false;
    void Start()
    {
        m_Animator= GetComponent<Animator> ();
        m_Rigidbody=GetComponent<Rigidbody>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!tart && Input.GetKeyDown(KeyCode.P)) tart=true;
        if(tart){
        remove();
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if(Input.GetKey(KeyCode.LeftShift)) Sprint=true;
        else Sprint=false;
        m_Movement.Set (horizontal,0f,vertical);
        m_Movement.Normalize();
        bool HorizontalInput = !Mathf.Approximately(horizontal,0f);
        bool VerticalInput = !Mathf.Approximately(vertical,0f);
        bool Walking = HorizontalInput || VerticalInput;
        if (Walking){
            if (!m_AudioSource.isPlaying){
                m_AudioSource.Play();
            }
        }else{
            m_AudioSource.Stop ();
        }
        m_Animator.SetBool("Walking",Walking);
        Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation (desiredForward);
        gemscore.text="Gems  :  "+gemcout;
        }
    }
    void OnAnimatorMove(){ 
        if(Sprint) m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement *2* m_Animator.deltaPosition.magnitude); 
        else m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement*(m_Animator.deltaPosition.magnitude)); 
        m_Rigidbody.MoveRotation (m_Rotation);
    }
    public void gemcoun(){
        gemcout++;
    }
    void remove(){
        init.alpha=0;
    }
}