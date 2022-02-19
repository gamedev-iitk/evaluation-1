using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    void Update()
    {
        scoretext.text = player.position.z.ToString("0");
    }
}
