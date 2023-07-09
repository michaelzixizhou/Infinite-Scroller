using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    private float timeBetweenSpawn_initial = 3;
    private float timeBetweenSpawn_growth = 0.05f;
    private float obstacleSpeed_growth = 0.1f;
    private float spawnTime;
    private float difficultyIncrease_growth = 1;
    private float difficultyIncrease = 10;
    private int difficulty = 1;
    private float lane_width;

    float timer;
    // Start is called before the first frame update
    void Start()
    {
        lane_width = GameManager.instance.lane_width;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > difficultyIncrease)
        {
            GameManager.instance.speed += obstacleSpeed_growth;
            timeBetweenSpawn_initial -= timeBetweenSpawn_growth;
            difficulty++;
            difficultyIncrease = Time.time + difficultyIncrease_growth;
        }
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + Random.Range(timeBetweenSpawn_initial*0.6f, timeBetweenSpawn_initial);
        }
        Debug.Log(GameManager.instance.speed);
    }

    void Spawn()
    {
        int random_spawn = Random.Range(0,3);
        int random_obstacle = Random.Range(0, obstacles.Length);
        switch (random_spawn)
        {
            case 0:
                Instantiate(obstacles[random_obstacle], new Vector2(-lane_width, 10), transform.rotation).GetComponent<Obstacle>().speed = GameManager.instance.speed;
                break;
            case 1:
                Instantiate(obstacles[random_obstacle],  new Vector2(0, 10), transform.rotation).GetComponent<Obstacle>().speed = GameManager.instance.speed;
                break;
            case 2:
                Instantiate(obstacles[random_obstacle], new Vector2(lane_width, 10), transform.rotation).GetComponent<Obstacle>().speed = GameManager.instance.speed;
                break;
        }


    }
}
