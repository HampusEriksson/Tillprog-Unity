using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject tigerPrefab;
    [SerializeField] GameObject deerPrefab;
    [SerializeField] GameObject chickenPrefab;
    [SerializeField] int tigerCount;
    [SerializeField] int deerCount;
    [SerializeField] int chickenCount;
    [SerializeField] float spawnRange;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < tigerCount; i++)
        {
            SpawnTiger();
        }
        for (int i = 0; i < deerCount; i++)
        {
            SpawnDeer();
        }
        for (int i = 0; i < chickenCount; i++)
        {
            SpawnChicken();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTiger()
    {
        
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, Random.Range(-spawnRange, spawnRange));
            Instantiate(tigerPrefab, spawnPos, tigerPrefab.transform.rotation);
        
    }

    public void SpawnDeer()
    {
  
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, Random.Range(-spawnRange, spawnRange));
            Instantiate(deerPrefab, spawnPos, deerPrefab.transform.rotation);
        
    }

    public void SpawnChicken()
    {
       
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, Random.Range(-spawnRange, spawnRange));
            Instantiate(chickenPrefab, spawnPos, chickenPrefab.transform.rotation);
        
    }

}