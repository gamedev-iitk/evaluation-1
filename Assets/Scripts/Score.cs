using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{  
    public static int sc=0; 
    public Text sco;
    void Start(){
        sc = 0;
    }
    void FixedUpdate()
    {   
        sco.text = sc.ToString();
    }
    
}

