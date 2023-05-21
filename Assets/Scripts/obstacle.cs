using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    private GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
        Debug.Log("COLLISION");
        // if(OtherObject == player)
        // {
        Destroy(OtherObject.gameObject);
        // }
    }
}
