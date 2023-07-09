using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_looper : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;
    public GUIScript GUI;
    [SerializeField] public ColorChangeScript colorChanger;

    // Update is called once per frame
    void Update()
    {   
        if (GUI.num_score % 500 == 0) {
            colorChanger.StartChangingColors();
        }
        backgroundRenderer.material.mainTextureOffset += new Vector2(0f, backgroundSpeed * Time.deltaTime);
    }
}
