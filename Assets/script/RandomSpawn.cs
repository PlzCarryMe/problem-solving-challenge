using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Vector3 center, size;
    public GameObject[] spawnees;

    Transform test;

    public float spawnTime;
    public float spawnDelay;

    public int currspawn = 0;
    public int maxspawn;

    // Start is called before the first frame update
    void Start()
    {
        test = GetComponent<Transform>();
        center = test.position;
        maxspawn = Random.Range(10, 25);
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

    }

    public void SpawnObject()
    {
        Vector3 pos = center + new
                Vector3(Random.Range(-size.x / 2, size.x / 2),
                Random.Range(-size.y / 2, size.y / 2),
                Random.Range(-size.z / 2, size.z / 2));

        int randomInt = Random.Range(0, spawnees.Length);

        if (currspawn < maxspawn)
        {
            Instantiate(spawnees[randomInt], pos, Quaternion.identity);
            currspawn++;
        }
 
    }


}
