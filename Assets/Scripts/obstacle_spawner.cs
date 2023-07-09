using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_spawner : MonoBehaviour
{
    public GameObject[] obstacles;
    private float timeBetweenSpawn_initial = 3;
    private float timeBetweenSpawn_growth = 0.05f;
    private float obstacleSpeed_initial = 2;
    private float obstacleSpeed_growth = 0.1f;
    private float spawnTime;
    private float difficultyIncrease_growth = 1;
    private float difficultyIncrease = 10;
    private int difficulty = 1;

    float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > difficultyIncrease)
        {
            obstacleSpeed_initial += obstacleSpeed_growth;
            timeBetweenSpawn_initial -= timeBetweenSpawn_growth;
            difficulty++;
            difficultyIncrease = Time.time + difficultyIncrease_growth;
        }
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + Random.Range(timeBetweenSpawn_initial*0.6f, timeBetweenSpawn_initial);
        }
        Debug.Log(obstacleSpeed_initial);
    }

    void Spawn()
    {
        int random_spawn = Random.Range(0,3);
        int random_obstacle = Random.Range(0, obstacles.Length);
        switch (random_spawn)
        {
            case 0:
                Instantiate(obstacles[random_obstacle], transform.position + new Vector3(-3, 10, -10), transform.rotation).GetComponent<obstacle>().speed = obstacleSpeed_initial;
                break;
            case 1:
                Instantiate(obstacles[random_obstacle], transform.position + new Vector3(-1, 10, -10), transform.rotation).GetComponent<obstacle>().speed = obstacleSpeed_initial;
                break;
            case 2:
                Instantiate(obstacles[random_obstacle], transform.position + new Vector3(1, 10, -10), transform.rotation).GetComponent<obstacle>().speed = obstacleSpeed_initial;
                break;
        }


    }
}
