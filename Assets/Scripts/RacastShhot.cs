using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacastShhot : MonoBehaviour
{
    public Camera playercamera;
    public float FireRate = 10f;
    private float timeBetweenNextShot;
    public float Damage = 20f;
    void Update()
    {
        if(Input.GetButton("Fire1")&& Time.time >= timeBetweenNextShot)
        {
            timeBetweenNextShot = Time.time + 1f/FireRate;
            weapon();
        }
    }
    void weapon()
    {
            RaycastHit hit;
            if(Physics.Raycast(playercamera.transform.position, playercamera.transform.forward, out hit))
            {
                if(hit.transform.tag == "Enemy")
                {
                    Debug.Log(hit.transform.name);
                    Health enemy = hit.transform.GetComponent<Health>();
                    enemy.Damage(Damage);
                }
            }
    }
}
