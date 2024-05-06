using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAttack : MonoBehaviour
{
    [SerializeField] GameObject bullet;
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
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = transform.position;
            timer = 0;
            Destroy(newBullet, 5f);
        }
    }
}
