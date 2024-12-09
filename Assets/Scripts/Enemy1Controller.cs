using UnityEngine;

public class Enemy1Controller : MonoBehaviour
{
    public float health = 3f; 
    public float speed = 1f; 
    public Vector2 direction = Vector2.zero; 
    public Animator animator;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        UpdateAnimation();
    }

    private void Move()
    {
        if (direction.magnitude > 0) 
        {
            Vector2 newPosition = _rb.position + direction.normalized * speed * Time.deltaTime;
            _rb.MovePosition(newPosition);
        }
    }

    private void UpdateAnimation()
    {
        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.magnitude);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
        else
        {
            animator.SetTrigger("Hurt");
        }
    }

    private void Die()
    {
        animator.SetTrigger("Death"); 
        Destroy(gameObject, 1f);
    }
}
