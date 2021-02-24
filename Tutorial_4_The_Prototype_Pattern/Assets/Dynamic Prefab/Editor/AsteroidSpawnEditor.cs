using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AsteroidSpawner))]
public class AsteroidSpawnEditor : Editor
{
    private string path;
    private string assetpath;
    private string filename;

    private void OnEnable()
    {
        path = Application.dataPath + "/Asteroid";
        assetpath = "Assets/Asteroid";
        filename = "asteroid_" + System.DateTime.Now.Ticks.ToString();
    }

    public override void OnInspectorGUI()
    {
        AsteroidSpawner astSpawner = (AsteroidSpawner) target;
        DrawDefaultInspector();

        if (GUILayout.Button("Create Asteroid"))
            astSpawner.CreateAsteroid();
        if (GUILayout.Button("Save Asteroid"))
        {
            System.IO.Directory.CreateDirectory(path);
            Mesh mesh = astSpawner.asteroid.GetComponent<MeshFilter>().sharedMesh;
            AssetDatabase.CreateAsset(mesh,assetpath+mesh.name+ ".asset");
            AssetDatabase.SaveAssets();

            PrefabUtility.SaveAsPrefabAsset(astSpawner.asteroid, assetpath + filename + ".prefab");
        }
    }
}