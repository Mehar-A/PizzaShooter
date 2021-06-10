using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // respawning the animals all randoms
    public GameObject[] animalsPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float startDelay = 1;
    private float spawninterval = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawninterval);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    void SpawnRandomAnimals()
    {
        // change it later for position of your animals and the hitbox sizes
        int animalIndex = Random.Range(0, animalsPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);
    }
}
