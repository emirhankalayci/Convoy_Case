using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnRangeX0 = 35.0f;
    private float spawnRangeX0_1 = 29.0f;
    private float spawnRangeX1 = 25.5f;
    private float spawnRangeX1_1 = 19.7f;
    private float spawnRangeX2 = 16.0f;
    private float spawnRangeX2_1 = 10.1f;
    private float spawnRangeX3 = 6.5f;
    private float spawnRangeX3_1 =  0.7f;
    private float spawnRangeX4 = -3f;
    private float spawnRangeX4_1 = -8.5f;
    private float spawnRangeX5 = -12.5f;
    private float spawnRangeX5_1 = -18.5f;

    private int spawnPosZ = 100;
 

    [SerializeField] public int SpawnNum;
    

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < SpawnNum; i++)
        {
            SpawnRandomCar();
            SpawnRandomCar1();
            SpawnRandomCar2();
            SpawnRandomCar3();
            SpawnRandomCar4();
            SpawnRandomCar5();

        }
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void SpawnRandomCar()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX0, spawnRangeX0_1), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);

    }
    
    void SpawnRandomCar1()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX1, spawnRangeX1_1), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    void SpawnRandomCar2()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX2, spawnRangeX2_1), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    void SpawnRandomCar3()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX3, spawnRangeX3_1), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    void SpawnRandomCar4()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX4, spawnRangeX4_1), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    void SpawnRandomCar5()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX5, spawnRangeX5_1), 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }

    
}
