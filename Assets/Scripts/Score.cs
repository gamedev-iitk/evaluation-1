using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{  
    public static int sc=0; 
    public Text score;
    void Start(){
        sc = 0;
    }
    public void reStart(){
        Invoke("re",Game_Over.restart_delay);
    }
    void FixedUpdate()
    {   
        score.text = sc.ToString();
    }
    
}
