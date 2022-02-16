using UnityEngine;
using UnityEngine.SceneManagement;
public class Play_Quit : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Level");
    }
    public void quit(){
        Debug.Log("QUIT");
        Application.Quit();
        
    }
}
