using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostCube : MonoBehaviour
{
    public GameObject player;
    public CanvasGroup image;
    Vector3 distance;
    void Start()
    {
        image.alpha=0;
    }
    void Update()
    {
        distance=transform.position-player.transform.position;
        if(distance.magnitude<3)
        {
            image.alpha= (3-distance.magnitude)/3;
        }
    }
}
