using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void ResetScene()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
