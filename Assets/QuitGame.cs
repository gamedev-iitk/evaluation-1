using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void QuitIt()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
