using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransitions : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(loadScene());
        }
    }

    IEnumerator loadScene()
    {
        
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);

    }
}
