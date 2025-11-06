using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Jump : MonoBehaviour
{
   // public AudioClip jumpSound;
    //public AudioClip walkSound;
    //private AudioSource audioSource;
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.1f;
    public LayerMask groundLayer;
    public float spring = 2.5f;
    public LayerMask springLayer;
    

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isSpring;
    //private int jumpCount = 0;
    //private int maxJump = 20;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //audioSource = GetComponent<AudioSource>();
        rb.freezeRotation = true;
    }
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = rb.linearVelocity;
        velocity.x = moveX * moveSpeed;
        rb.linearVelocity = velocity;


        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);


        isSpring = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, springLayer);
        if (isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
        if (isSpring){
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce * spring);
        }
    }
}
