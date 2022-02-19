using UnityEngine;

public class ObsatcleSpawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject blockPrefab;
    public float timebtwaves = 1.4f; 
    private float timeToSpawn = 0.7f;
    void Update() 
    {
        if(Time.time >= timeToSpawn )
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timebtwaves ;
        }
       
    }
    
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0,spawnpoints.Length);

        for(int i = 0; i<spawnpoints.Length; i++)
        {
            if(randomIndex != i)
            {
                Instantiate(blockPrefab, spawnpoints[i].position, Quaternion.identity);
            }
        }
    }

    
}
