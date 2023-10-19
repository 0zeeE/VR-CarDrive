using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    private int initAmount = 10;
    private float plotSize = 30f;
    private float xPosLeft = -38.25f;
    private float xPosRight = 38.25f;
    private float lastZPos= 15f;

    public List<GameObject> plots;

    void Start()
    {
        for (int i = 0; i < initAmount; i++) //rastgele doku gelistirmek icin
        {
            SpawnPlot();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlot()
    {
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];

        float zPos = lastZPos + plotSize;

        Instantiate(plotLeft, new Vector3(xPosLeft, 0.025f, zPos), plotLeft.transform.rotation);
        Instantiate(plotRight, new Vector3(xPosRight, 0.025f, zPos), new Quaternion(0, 180, 0, 0)); //ayný prefab'ý 180 derece çevirip karþýya taþýmak için

        lastZPos += plotSize;
    }
}
