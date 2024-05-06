using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAttack : MonoBehaviour
{
    [SerializeField] GameObject bullet1;
    [SerializeField] GameObject bullet2;
    float timer = 0;
    [SerializeField] float spawnCoolTime;
    [SerializeField] private bool shotMode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            shotMode = !shotMode;
        }
        timer += Time.deltaTime;
        if (shotMode)
        {
            if (timer > spawnCoolTime){
                GameObject newBullet = Instantiate(bullet1);
                newBullet.transform.position = transform.position;
                timer = 0;
                Destroy(newBullet, 5f);
            }
        }
        else
        {
           if (timer > spawnCoolTime*3){
                GameObject newBullet = Instantiate(bullet2);
                newBullet.transform.position = transform.position;
                timer = 0;
                Destroy(newBullet, 5f);
            } 
        }
    }
}
