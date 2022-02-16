using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text positionText;
    // Update is called once per frame
    void Update()
    {
         positionText.text = (player.position.x+player.position.y+player.position.z).ToString("0");
    }
}
