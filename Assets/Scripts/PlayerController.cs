using UnityEngine;
using Assets.Scripts;


public class PlayerController : MonoBehaviour, IPlayer
{
    public string username { get; set; } = "Player";
    public float health { get; set; } = 100;
    public float experience { get; set; } = 0;
    public float speed { get; set; } = 1f;
    public float sprint { get; set; } = 2f;

    public Animator animator;
    public GameObject attackZone;

    private Vector2 direction;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        attackZone.SetActive(false);
        Die();

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.magnitude);
        animator.SetBool("IsRunning", Input.GetKey(KeyCode.LeftShift));

        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsRunning", Input.GetKey(KeyCode.LeftShift));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    private void FixedUpdate()
    {
        float currentSpeed = speed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed *= sprint;

        }
        rb.MovePosition(rb.position + direction * currentSpeed * Time.fixedDeltaTime);
    }

    private void Attack()
    {
        animator.SetTrigger("Attack");
    }

    public void EnableAttackZone() 
    {
        attackZone.SetActive(true);
    }

    public void DisableAttackZone() 
    {
        attackZone.SetActive(false);
    }

    protected void Die()
    {
        if (health <= 0)
        {
            animator.SetTrigger("Death");
        }
    }

    public void OnDeathAnimationEnd()
    {
        Destroy(gameObject);
    }
    


    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
}
