using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 40f;
    public void Damage(float amount)
    {
        health -= amount;
    }
    void Update()
    {
        if(health<=0f)
        {
            Destroy(gameObject);
        }
    }
}
