using UnityEngine;

public interface IPlayer
{
        public string username { get; set; }
        public float health { get; set; }
        public float experience { get; set; }
}

public class PlayerController : MonoBehaviour, IPlayer
{
    public float speed = 1f;
    public float sprint = 2f;
    public Animator animator;
    private Vector2 direction;
    private Rigidbody2D rb;

    public string username { get; set; } = "Player";
    public float health { get; set; } = 100;
    public float experience { get; set; } = 0;

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

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.magnitude);
        animator.SetBool("IsRunning", Input.GetKey(KeyCode.LeftShift));
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

}
