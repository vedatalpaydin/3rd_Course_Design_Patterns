using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorldCube : MonoBehaviour
{
    public int width;
    public int depth;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < width; x++)
            for (int z = 0; z < depth; z++)
            {
                Vector3 pos = new Vector3(x, Mathf.PerlinNoise(x*.5f,z*.5f), z);
                GameObject go = Instantiate(cube,pos,Quaternion.identity);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
