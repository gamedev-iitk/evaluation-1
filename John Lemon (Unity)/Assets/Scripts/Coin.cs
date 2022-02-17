using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Transform coin;
    public GameObject player;
    public GameObject m_Coin;
    public Variables c_Score;
    AudioSource m_AudioSource;
    public float speed = 0.5f;
    bool IsCollected;

    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
  
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
        if(IsCollected)
        {
            m_AudioSource.Play ();
            c_Score.value+=1;
            //Debug.Log(c_Score.value);
            Destroy(m_Coin);
        }

    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            IsCollected=true;
        }
    }
}
