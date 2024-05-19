using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    [SerializeField]Rigidbody2D pipe1, pipe2, pipe3, onlyObstacle;
    
    void Start()
    {
        pipe1.velocity = new Vector3(-speed, 0, 0);
        pipe2.velocity = new Vector3(-speed, 0, 0);
        pipe3.velocity = new Vector3(-speed, 0, 0);
        onlyObstacle.velocity = new Vector3(-speed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
