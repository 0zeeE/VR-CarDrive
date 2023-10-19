using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private int spawnInterval = 60;
    private int lastSpawnZ = 90;
    private int spawnAmount = 4;

    public List<GameObject> obstaclesLeft;
    public List<GameObject> obstaclesRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacles()
    {
        lastSpawnZ += spawnInterval;

        for(int i = 0; i < spawnAmount; i++ )
        {
            
            if(Random.Range(0,4) == 0) //%33 sansla sol seritte dogacak
            {
                GameObject obstacle = obstaclesLeft[(Random.Range(0, obstaclesLeft.Count))];

                Instantiate(obstacle, new Vector3(Random.Range(-5.0f,-1.5f),0f,lastSpawnZ + Random.Range(-15f,15f)),obstacle.transform.rotation);
            }
            else if (Random.Range(0, 4) == 1) //%33 sansla sag seritte dogacak
            {
                GameObject obstacle = obstaclesRight[(Random.Range(0, obstaclesRight.Count))];

                Instantiate(obstacle, new Vector3(Random.Range(1.5f, 5f), 0.25f, lastSpawnZ+ Random.Range(-15f,15f)), obstacle.transform.rotation);
            }
        }
    }

    
}
