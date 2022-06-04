
using UnityEngine;
using UnityEngine.SceneManagement;
public class StarGame : MonoBehaviour
{
    // Start is called before the first frame update
   public void StartGame()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );  
    }

}
