using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_spawner : MonoBehaviour
{
    public GameObject obstacle;
    public float timeBetweenSpawn;
    private float spawnTime;
    float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        int random_spawn = Random.Range(0,3);
        Debug.Log(random_spawn);
        switch (random_spawn)
        {
            case 0:
                Instantiate(obstacle, transform.position + new Vector3(-3, 10, -10), transform.rotation);
                break;
            case 1:
                Instantiate(obstacle, transform.position + new Vector3(-1, 10, -10), transform.rotation);
                break;
            case 2:
                Instantiate(obstacle, transform.position + new Vector3(-1, 10, -10), transform.rotation);
                break;
        }


    }
}
