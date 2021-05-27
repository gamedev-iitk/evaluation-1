using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinscript : MonoBehaviour
{
    // Start is called before the first frame update
  // public  AudioSource audiosource;
    public static AudioClip clip;
    void Start()
    {
        // audiosource = GetComponent<AudioSource>();
        //clip = Resources.Load<AudioClip>("coinrsound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // audiosource.PlayOneShot(clip);

            // audiosource.Play();
            // gameObject.GetComponent<AudioSource>().Play();
            //Debug.Log(audiosource);
            AudioSource coins = GameObject.Find("coinsound").GetComponent<AudioSource>();
            coins.Play();

            GameObject gm= GameObject.Find("Score");
            string str = gm.GetComponent<TextMeshProUGUI>().text;
            Debug.Log(gm.GetComponent<TextMeshProUGUI>().text);
            coincounter.scor--;
            Destroy(gameObject);
        }
        

    }
}
