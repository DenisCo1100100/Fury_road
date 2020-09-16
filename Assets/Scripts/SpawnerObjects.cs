using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    public bool isSameDelay;
    public bool isRanomObject;
    public GameObject objectToSpawn;
    public GameObject[] objectsToSpawn;
    public float timeBeforeSpawn;
    public float spawnDelay;
    public float minDelay;
    public float maxDelay;


    void Start()
    {
        if (isSameDelay)
        {
            InvokeRepeating("Spawn", timeBeforeSpawn, spawnDelay);
        }
        else
        {
            StartCoroutine(Spawner());
        }
    }

    private IEnumerator Spawner()
    {
        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        Spawn();
    }

    private void Spawn()
    {
        
        if (isRanomObject)
        {
           GameObject obj = Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], transform.position, transform.rotation) as GameObject;
        }
        else
        {
            GameObject obj = Instantiate(objectToSpawn, transform.position, transform.rotation) as GameObject;
        }

        if (!isSameDelay)
        {
            StartCoroutine(Spawner());
        }
    } 

    void Update()
    {
        
    }
}
