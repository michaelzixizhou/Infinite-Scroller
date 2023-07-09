using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    public Color target_color;
    public Color curr_color;
    public Color transition;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        curr_color = gameObject.GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.enabled){
            time += 0.0005f;
            transition = Color.Lerp(curr_color, target_color, time / 1f);
            gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", transition);
        }

        if (time > 0.999f) {
            curr_color = transition;
            this.enabled = false;
            time = 0f;
        }
    }

    public void StartChangingColors(){
        target_color = Random.ColorHSV(0.2f, 0.8f, 0.2f, 0.8f, 0.2f, 0.8f, 0.2f, 0.8f);
        time = 0;
        this.enabled = true;
    }
}
