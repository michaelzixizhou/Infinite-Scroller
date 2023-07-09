using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : Obstacle
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(0, Time.deltaTime*speed, 0);
        if (this.transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D OtherObject)
    {
        Destroy(this.gameObject);
    }  
}
