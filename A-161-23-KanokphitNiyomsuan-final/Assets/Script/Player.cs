using UnityEngine;

public class Player : MonoBehaviour
{
    [field : SerializeField] private float moveSpeed = 5f;
    private float jumpForce = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void SetMoveSpeed(float newSpeed)
    {

        Debug.Log("Player speed Increase "+ newSpeed );
    }

    public void SetInvulnerability(bool isEnabled)
    {
        Debug.Log("");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    public void Move()
    {
        
    }

    public void Jump()
    {

    }
}
