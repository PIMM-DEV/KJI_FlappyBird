using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Score.bestScore < Score.score) {
            Score.bestScore = Score.score;
        }   
        GetComponent<Text>().text = "Best Score : "  + Score.bestScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
