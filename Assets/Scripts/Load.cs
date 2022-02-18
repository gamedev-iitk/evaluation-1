using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public int sceneToLoad;
    AsyncOperation loadingOperation;
    public Text percentLoaded;

    public GameObject LoadScrene;
    public Slider slider;
    
    public void LoadLevel( int sceneToLoad)
    {
        StartCoroutine(LoadAsynchronously(sceneToLoad));

    }

    IEnumerator LoadAsynchronously (int sceneToLoad)
    {
        AsyncOperation loadingOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        LoadScrene.SetActive(true);
        

        while (!loadingOperation.isDone)
        {
            float progress = Mathf.Clamp01(loadingOperation.progress / 0.9f);
            slider.value = progress;
            percentLoaded.text = progress * 100f + "%";
            yield return null;
        }
    }
}
