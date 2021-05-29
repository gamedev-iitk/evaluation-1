using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void restartgame()
    {
        // #if UNITY_EDITOR //
        //     UnityEditor.EditorApplication.isPlaying = false;
        // #else
            Debug.Log("Restart");
            SceneManager.LoadScene (0);
            ScoreText.CoinAmount =0;
        // #endif
    }
}
