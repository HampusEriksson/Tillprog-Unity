using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnAnimal()
    {
        int randomIndex = Random.Range(0, animalPrefabs.Length);
        int x = Random.Range(-15,15);
        Instantiate(animalPrefabs[randomIndex], new Vector3(x,0, 20), animalPrefabs[randomIndex].transform.rotation);
    }
}
