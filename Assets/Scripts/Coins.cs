using System.Collections;
using UnityEngine;
public class Coins : MonoBehaviour
{
    public Renderer rend;
    public Collider col;
    void OnCollisionEnter(Collision colinfo){
        if(colinfo.collider.tag=="Player"){
            rend.enabled=false;
            col.enabled = false;
            Score.sc++;
        }
    }
}
