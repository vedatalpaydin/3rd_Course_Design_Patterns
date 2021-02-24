﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject eggPrefab;
    public GameObject medKitPrefab;
    public Terrain terrain;
    private TerrainData terrainData;
    void Start()
    {
        terrainData = terrain.terrainData;
        InvokeRepeating("CreateEgg",1,1f);
        InvokeRepeating("CreateMedkit",1,0.1f);

    }

    void CreateEgg()
    {
        int x = (int) Random.Range(0, terrainData.size.x);
        int z = (int) Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 10;
        GameObject egg =  Instantiate(eggPrefab, pos, Quaternion.identity);
    }
    void CreateMedkit()
    {
        int x = (int) Random.Range(0, terrainData.size.x);
        int z = (int) Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 10;
        GameObject egg =  Instantiate(medKitPrefab, pos, Quaternion.identity);
    }
}
