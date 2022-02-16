using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu_Restart : MonoBehaviour
{   public Text sco;
    void Start(){
        sco.text = (Score.sc).ToString();
    }
    public void main_menu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void restart(){
        SceneManager.LoadScene("Level");
    }
}
