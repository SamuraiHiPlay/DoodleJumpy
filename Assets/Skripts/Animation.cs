using UnityEngine;
 
public class Animation : MonoBehaviour
{
    public Animator animator;
 
    private bool isShooting = false;
    private float shootTimer = 0f;
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius = 0.1f;
    public LayerMask groundLayer;
 
    public float shootDuration = 0.5f;
 
 
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }
 
 
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        bool jumping = !isGrounded;
        animator.SetBool("isJumping", jumping);
        if (Input.GetKeyDown(KeyCode.F) && !isShooting){
            isShooting = true;
            shootTimer = shootDuration;
            animator.SetBool("isShooting", true);
        }
        if (isShooting){
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0){
                isShooting = false;
                animator.SetBool("isShooting", false);
            }
        }
    }
}
