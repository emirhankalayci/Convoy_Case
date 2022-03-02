using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnRangeX = 18.0f;
    
    private float spawnRangeX1 = 18.0f;
    private float spawnRangeX2 = 23.5f;
    private float spawnRangeX3 = 16.5f;
    private float spawnRangeX4 = 16.5f;
    private float spawnRangeX5 = 16.5f;
    
    private int spawnPosZ = 100;
    private int startDelay = 2;
    private float spawnInterval = 1.5f;
    [SerializeField] GameObject spawn1, spawn2;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomCar();
        }     
    }

    void SpawnRandomCar()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX1), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);

    }
    
    void SpawnRandomCar1()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    void SpawnRandomCar2()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX2, spawnRangeX2), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    void SpawnRandomCar3()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX3, spawnRangeX3), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    void SpawnRandomCar4()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX4, spawnRangeX4), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    void SpawnRandomCar5()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX5, spawnRangeX5), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    
}
