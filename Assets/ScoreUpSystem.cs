using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpSystem : MonoBehaviour
{
    private int startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = (int)Time.time;
        Score.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Score.score = (int)Time.time - startTime;
    }
}
