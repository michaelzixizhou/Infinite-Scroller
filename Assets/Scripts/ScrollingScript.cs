using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScrollingScript : MonoBehaviour
{
    // scrollingScript, scrolling_script, ScrollingScript
    [SerializeField] public MeshRenderer meshRenderer;
    [SerializeField] public GameObject GUI;
    [SerializeField] ColorChangeScript colorChanger;
    private Color color;

    public float counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float sine = Mathf.Sin(counter);

        if (GUI.GetComponent<GUIScript>().num_score % 500 == 0){
            colorChanger.StartChangingColors();
        } else {
            color = meshRenderer.material.color;  
        }

        color.b = sine;
        meshRenderer.material.SetColor("_Color", color);
        counter += 0.0001f;
        if (counter > Mathf.PI * 2) {
            counter = 0f;
        }
    }
}
