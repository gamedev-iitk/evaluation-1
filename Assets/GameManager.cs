using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public float restartdelay = 1f;
    bool gameHasEnded = false;
    public void EndGame()
    {
        
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartdelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
