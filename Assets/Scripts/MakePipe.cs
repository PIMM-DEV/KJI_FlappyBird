using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] GameObject obstacle;
    [SerializeField] float spawnCoolTime = 2;
    float pipeTimer = 0;
    float obstacleTimer;
    // Start is called before the first frame update
    void Start()
    {
        obstacleTimer = spawnCoolTime/2;
    }

    // Update is called once per frame
    void Update()
    {
        pipeTimer += Time.deltaTime;
        obstacleTimer += Time.deltaTime;
        if (pipeTimer > spawnCoolTime){
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(transform.position.x, Random.Range(-2f, 2f), 0);
            pipeTimer = 0;
            Destroy(newPipe, 10f);
        }
        if (obstacleTimer > spawnCoolTime) {
            GameObject newObstacle = Instantiate(obstacle);
            newObstacle.transform.position =  new Vector3(transform.position.x, Random.Range(-2f, 2f), 0);
            obstacleTimer = 0;
            Destroy(newObstacle, 10f);
        }
    
    }
}
