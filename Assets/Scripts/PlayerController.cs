using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float sprint = 2f;
    public Animator animator;
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
    public void Up()
    {
        direction.y = 100;
        FixedUpdate();
        //float currentSpeed = speed;
        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    currentSpeed *= sprint;
        //}
        //Debug.Log(currentSpeed);
        //Debug.Log(direction.y);
        //Debug.Log(rb.position);
        //transform.position = rb.position + direction * currentSpeed * Time.fixedDeltaTime;
        //rb.MovePosition(rb.position + direction * currentSpeed * Time.fixedDeltaTime);

    }
}
