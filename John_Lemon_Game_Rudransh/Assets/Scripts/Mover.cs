using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float speed;
    void Start()
    {
        speed = 20;
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            ScoreText.gamescore += 10;
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
        else
            Destroy(gameObject);
    }
}