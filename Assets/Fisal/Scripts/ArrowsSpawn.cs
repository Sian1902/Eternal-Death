using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsSpawn : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;



    void Update()
    {
        if (Time.time > spawnTime)
        {
            SpawnObj();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void SpawnObj()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
