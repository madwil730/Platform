using UnityEngine;
using UnityEngine.InputSystem;




[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 7f;

    private Rigidbody2D rb;
    private float moveInput; 
    private bool isGrounded = false; 

    [Header("Ground Check")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask groundLayer;

    public float HP;
    public float Damage;
    public bool IsDaed;
    public Animator anim;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        Debug.Log(isGrounded);
		anim.SetBool("Walk", Mathf.Abs(rb.linearVelocity.x) > 0.01f || Mathf.Abs(rb.linearVelocity.y) > 0.01f);

		// --- 공격 ---
		if (Input.GetKeyDown(KeyCode.Mouse0))
			anim.SetTrigger("Attack");

		// --- 패링 ---
		if (Input.GetKeyDown(KeyCode.Mouse1))
			anim.SetTrigger("Parry");
	}



    public void OnMove(InputAction.CallbackContext ctx)
    {
        Vector2 move = ctx.ReadValue<Vector2>();
        moveInput = move.x; 
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        Debug.Log(isGrounded);
        if (ctx.performed && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            Debug.Log("Jump!");
        }
    }


}
