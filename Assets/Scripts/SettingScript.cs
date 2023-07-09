using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScript : MonoBehaviour
{
    [SerializeField] public GameObject pause_menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pause_menu.SetActive(true);
        }
        else {
            ResumeGame();
        }
}

    public void ResumeGame(){
        Time.timeScale = 1;
        pause_menu.SetActive(false);
    }
}
