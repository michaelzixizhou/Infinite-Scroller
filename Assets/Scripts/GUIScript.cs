using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUIScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text _score;
    public int num_score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameManager.instance.game_over){
            num_score += 1;
            _score.text = num_score.ToString();
        }
    }
}
