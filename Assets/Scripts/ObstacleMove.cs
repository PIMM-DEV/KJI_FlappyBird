using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField]private int plusX = -1;
    [SerializeField]private int plusY = -1;
    [SerializeField] int pipeSpeed;
    Rigidbody2D rb;
    // Update is called once per frame
    void Start()
    {
        int rdY = Random.Range(0,2);
        if (rdY == 1) {
            plusY = 1;
        }
        else {
            plusY = -1;
        }
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(-(pipeSpeed+speed), plusY*speed, 0);
    }
    void Update()
    {/*
        transform.position += Vector3.left * speed * Time.deltaTime;
        transform.position += Vector3.right * plusX * plusSpeed * Time.deltaTime;
        transform.position += Vector3.up * plusY * plusSpeed * Time.deltaTime;*/
        
    }
    private void OnCollisionEnter2D(Collision2D other) {/*
        if (other.gameObject.tag == "Pipe") {
            plusX = -plusX;
        }
        if (other.gameObject.tag == "UpDownWall") {
            plusY = -plusY;
        }*/

    }

}
