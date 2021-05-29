// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class AudioController : MonoBehaviour
// {
//     AudioSource audioSource;
//     bool isMuted = false;

//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.M) & !isMuted)
//         {
//             audioSource.Stop();
//         }
//         if (Input.GetKeyDown(KeyCode.M) & isMuted)
//         {
//             audioSource.Play();
//         }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            audioSource.mute = !audioSource.mute;
        }
    }
}
