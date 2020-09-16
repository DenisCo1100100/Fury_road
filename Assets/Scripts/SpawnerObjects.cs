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

    // Start is called before the first frame update
    void Start()
    {
        if (isSameDelay)
        {
            InvokeRepeating("Spawn", timeBeforeSpawn, spawnDelay);
        }
        else
        {
            
        }
    }

    private IEnumerator Spawner()
    {
        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        Spawner();
    }

    private void Spawn()
    {
        
        if (isRandomObject)
        {
           GameObkect obj = Instantiate(ObjectsToSpwan[Random.Range(0, ObjectsToSpwan.Length)], transform.position, transform.rotation) as GameObject;
        }
        if (!isRanomObject)
        {
            GameObject obj = Instantiate(objectToSpawn, transform.position, transform.rotation) as GameObject;
        }
        else if (!isSameDelay)
        {
            StartCorotine(Spawner());
        }
    } 
    // Update is called once per frame
    void Update()
    {
        
    }
}
