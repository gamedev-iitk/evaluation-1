using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
