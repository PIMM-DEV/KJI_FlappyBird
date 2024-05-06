using UnityEngine;
using UnityEngine.Purchasing;

public class Status : MonoBehaviour
{
    private Status otherStat;
    public int HP;
    public int Damage;

    private void OnCollisionEnter2D(Collision2D other) {
        otherStat = other.gameObject.GetComponent<Status>();
        HP -= otherStat.Damage;
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
