using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerSc : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    public int randX;
    public int startDelay = 2;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomAnimal", startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            spawnRandomAnimal();
        }
    }
    void spawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        randX = Random.Range(-23, 23);
        Instantiate(animalPrefabs[animalIndex], new Vector3(randX, 0.3f, 30), animalPrefabs[animalIndex].transform.rotation);
    }
}
