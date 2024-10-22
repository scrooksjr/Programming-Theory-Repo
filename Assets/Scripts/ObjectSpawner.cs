using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Demonstration of abstraction (higher-level methods that abstract unnecessary details).
    // Add a comment in the code that says “// ABSTRACTION” to indicate where it was implemented.

    public GameObject[] objectPrefab;
    public int izzy = 1;
    public int winston = 2;

    // Start is called before the first frame update
    private void Start()
    {
        SpawnObject(); // call higher-level method in Start().
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject() // create new higher-level method.
    {
        for (int i = 0; i < 3; i++)
        {
            
        }
    }

    private Vector3 GenerateSpawnPostion()
    {
        throw new NotImplementedException();
    }
}