
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public Material material;
    public GameObject asteroid;


    public void CreateAsteroid()
    {
        asteroid = ProcAsteroid.Clone(transform.position);
        asteroid.GetComponent<MeshRenderer>().sharedMaterial = material;
    }
    
}
