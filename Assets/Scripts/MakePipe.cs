using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    float timer = 0;
    [SerializeField] float spawnCoolTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnCoolTime){
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(transform.position.x, Random.Range(-3f, 3f), 0);
            timer = 0;
            Destroy(newPipe, 10f);
        }
    }
}
