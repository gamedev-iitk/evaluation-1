using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Over : MonoBehaviour
{
    bool game_ended = false;
    public static float restart_delay =1f;
    public void EndGame()
    {
        if(!game_ended){
            game_ended = true;
            Invoke("Restart",restart_delay);
        }
    }
    void Restart(){
        SceneManager.LoadScene("End_Screen");
    }
}
