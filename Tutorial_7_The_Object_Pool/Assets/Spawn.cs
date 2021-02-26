using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    void Update()
    {
        if (Random.Range(0, 100) < 5)
        {
            GameObject a = Pool.singleton.Get("Asteroid");
            if (a != null)
            {
                a.transform.position =transform.position + new Vector3(Random.Range(-5, 5), 0, 0);
                a.SetActive(true);
            }
        }
    }
}