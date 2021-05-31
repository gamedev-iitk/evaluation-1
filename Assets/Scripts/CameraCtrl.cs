using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public Animator camCtrl;
    public PlayerMovement player;
    public GameObject plr;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == plr)
        {
            camCtrl.SetBool("atEnding", true);
            player.SwitchAxis();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == plr)
        {
            camCtrl.SetBool("atEnding", false);
            player.Orignal();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            camCtrl.SetBool("gameStart", true);

        }
    }
}
