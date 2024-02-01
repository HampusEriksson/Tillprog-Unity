using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int spawnX = Random.Range(-10, 10);

        Instantiate(animalPrefabs[animalIndex], new Vector3(spawnX,0,20), animalPrefabs[animalIndex].transform.rotation);
    }
}
