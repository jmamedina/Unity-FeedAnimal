using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //array of animal prefabs
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private float spawnPosX = 20;
    private float spawnRangeTopZ = 16;
    private float spawnRangeBottomZ = 4;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
     

        //if we pressed "S" on keyboard
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRandomAnimal();
        //}
    }

    void SpawnRandomAnimal()
    {
        //index of animal in an array
        int animalIndex = Random.Range(0, 2);

        //top
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        Vector3 spawnPosRight = new Vector3(spawnPosX, 0, Random.Range(spawnRangeBottomZ, spawnRangeTopZ));
        Instantiate(animalPrefabs[3], spawnPosRight, animalPrefabs[3].transform.rotation);

        Vector3 spawnLeft = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeBottomZ, spawnRangeTopZ));
        Instantiate(animalPrefabs[4], spawnLeft, animalPrefabs[4].transform.rotation);


    }
}
