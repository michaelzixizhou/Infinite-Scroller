using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float device_width;
    public float device_height;
    public float lane_width;
    public float speed = 2f;
    public bool game_over = false;

    private void Awake() {
        instance = this;
        device_width = 2f * Camera.main.orthographicSize * Camera.main.aspect;
        device_height =  2f * Camera.main.orthographicSize;
        lane_width = device_width / 3;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
