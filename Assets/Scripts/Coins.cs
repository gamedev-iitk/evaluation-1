using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coins : MonoBehaviour
{
    public AudioClip coinSound;
    
    
   
        void OnTriggerEnter (Collider other)
        {
            if(other. name == "JohnLemon")
            {
               AudioSource.PlayClipAtPoint(coinSound  , transform.position); 
                
                Destroy(gameObject);
            }
        }    
}
