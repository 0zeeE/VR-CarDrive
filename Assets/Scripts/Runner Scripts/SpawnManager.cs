using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public RoadSpawner roadSpawner;
    public PlotSpawner plotSpawner;
    public ObstacleSpawner obstacleSpawner;

    void Start()
    {
        roadSpawner.GetComponent<RoadSpawner>();
        plotSpawner.GetComponent<PlotSpawner>();
        obstacleSpawner.GetComponent<ObstacleSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        plotSpawner.SpawnPlot();
        plotSpawner.SpawnPlot();
        plotSpawner.SpawnPlot();
        obstacleSpawner.SpawnObstacles();
        
    }
}
