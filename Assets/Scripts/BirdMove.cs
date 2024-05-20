using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float jumpPower;
    [SerializeField] private float LRSpeed;
    [SerializeField] private bool shotMode;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up* jumpPower;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += Vector3.left*Time.deltaTime*LRSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += Vector3.right*Time.deltaTime*LRSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        SceneManager.LoadScene("MenuScene");
    }
}
