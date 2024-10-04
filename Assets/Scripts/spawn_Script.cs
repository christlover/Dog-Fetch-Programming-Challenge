using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_Script : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;

    private float startDelay = 2;
    private float spawnInterval = Random.Range(1.0f, 3.0f);

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
            int animalIndex = Random.Range(0, animalPrefabs.Length); //Local Variable to Specify Range of Random Animal Selected

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ); //Local Vector 3 to Randomly Place Animal

            Instantiate(animalPrefabs[animalIndex], spawnPosition, //Randomly spawn animals
                animalPrefabs[animalIndex].transform.rotation);
    }
}
