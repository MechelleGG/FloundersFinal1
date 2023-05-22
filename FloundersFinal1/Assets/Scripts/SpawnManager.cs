using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] humanPrefab;
    public GameObject[] RockPrefab;
    private float spawnRangeX = 10;
    private float spawnPosZ = 10;

    private float startDelay = 3;
    private float spawnInterval = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomHuman", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomRock", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomHuman()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
        int humanIndex = Random.Range(0, humanPrefab.Length);
        Instantiate(humanPrefab[humanIndex], spawnPos, humanPrefab[humanIndex].transform.rotation);
    }

    void SpawnRandomRock()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
        int RockIndex = Random.Range(0, RockPrefab.Length);
        Instantiate(RockPrefab[RockIndex], spawnPos, RockPrefab[RockIndex].transform.rotation);
    }
}
