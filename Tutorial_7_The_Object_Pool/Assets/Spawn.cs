﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject asteroid;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 5)
            Instantiate(asteroid, transform.position + new Vector3(Random.Range(-10, 10), 0, 0), Quaternion.identity);
    }
}