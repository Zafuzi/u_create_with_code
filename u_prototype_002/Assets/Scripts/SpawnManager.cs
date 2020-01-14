using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnDelay = 2.0f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int to_spawn = Random.Range(0, animalPrefabs.Length);
        GameObject prefab_chosen = animalPrefabs[to_spawn];
        Instantiate(prefab_chosen, new Vector3(Random.Range(-20, 20),0,Random.Range(20, 35)), prefab_chosen.transform.rotation);
    }
}
