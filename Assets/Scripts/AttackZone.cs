using UnityEngine;

public class AttackZone : MonoBehaviour
{
    public float damage = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemy1Controller enemy = collision.GetComponent<Enemy1Controller>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
