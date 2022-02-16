using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        double x=49.71;
        scoreText. text = (Player.position.z+x).ToString("0");
        
    }
}
