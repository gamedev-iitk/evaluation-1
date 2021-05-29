using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniJohn : MonoBehaviour
{
    public SkinnedMeshRenderer[] ghost;
    public GameObject player;
    float time;
    bool flag;
    void Start()
    {
        for(int i=0;i<4;i++)
            {
                ghost[i].enabled=false;
            }
    }
    void OnTriggerEnter(Collider other) {
        if(other.gameObject==player)
        {
            flag=true;
            for(int i=0;i<4;i++)
            {
                ghost[i].enabled=true;
            }
        }
    }
    void Update()
    {
        if(flag)
        {
            time+=Time.deltaTime;
            if(time>7)
            {
                for(int i=0;i<4;i++)
                {
                    ghost[i].enabled=false;
                    flag=false;
                }
            }
        }
        
    }
}
