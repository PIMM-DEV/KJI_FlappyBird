
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

}
