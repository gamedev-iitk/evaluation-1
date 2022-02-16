using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;
    public float restartdelay=1f;

    public void EndGame(){
        if(gameHasEnded== false){
            gameHasEnded=true;
            Debug.Log("Game Over");
            Invoke("Restart",restartdelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
