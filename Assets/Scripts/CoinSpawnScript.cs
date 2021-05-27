using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] points;
    
    int Rand;
    List<int> list = new List<int>();
    public GameObject coin;

    void Start()
    {
        list = new List<int>(new int[4]);

        for (int j = 1; j <=3; j++)
        {
            Rand = Random.Range(1, points.Length);

            while (list.Contains(Rand))
            {
                Rand = Random.Range(1, 6);
            }

            list[j] = Rand;
            GameObject gm = Instantiate(coin, points[list[j]].transform.position, Quaternion.identity);
        }
       
           
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
