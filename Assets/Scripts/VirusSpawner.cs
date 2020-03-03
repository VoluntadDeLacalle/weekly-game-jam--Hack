using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSpawner : MonoBehaviour
{
    public float spawnTime;
    public float spawnBuffer;

    public GameObject virus;
    public GameObject firewall;
    private BoxCollider spawnCube;

    void Awake()
    {
        spawnCube = GetComponent<BoxCollider>();
    }

    void Start()
    {
        //print(spawnCube.bounds.min + " " + spawnCube.bounds.max);
        spawnTime = Time.time;
    }

    void Update()
    {

        if (Time.time - spawnTime >= spawnBuffer)
        {
            spawnVirus();
            spawnTime = Time.time;
        }
    }

    public void spawnVirus()
    {
        GameObject temp = Instantiate(virus);
        temp.transform.position = new Vector3(transform.position.x, .5f, Random.Range(spawnCube.bounds.min.z, spawnCube.bounds.max.z));
        temp.transform.forward = new Vector3(-1, 0, 0);
    }
}
