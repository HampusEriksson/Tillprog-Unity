using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private int enemyCount;
    private int level = 1;
    private int spawnRange = 7;

    // Start is called before the first frame update
    void Start()
    {
        SpawnWave();
        
    }

    // Update is called once per frame
    void Update()
    {

        enemyCount = FindObjectsOfType<EnemyController>().Length;

        if(enemyCount == 0)
        {
            level++;
            SpawnWave();
        }
        
    }

    void SpawnWave()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);

        for (int i = 0; i < level; i++) { 
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnX = Random.Range(-spawnRange, spawnRange);
        float spawnZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnX, 0, spawnZ);
        return randomPos;
    }
}
