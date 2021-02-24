using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;

    void Start()
    {
    }


    void Update()
    {
        if (Random.Range(0, 100) < 10)
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        else if (Random.Range(0, 100) < 10)
            Instantiate(spherePrefab, transform.position, Quaternion.identity);
    }
}