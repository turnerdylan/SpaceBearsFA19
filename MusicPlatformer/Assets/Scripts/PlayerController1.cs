using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Mirror;

public class PlayerController1 : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    bool canJump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");

        if (rb.bodyType == RigidbodyType2D.Dynamic)
        {
            rb.velocity = new Vector3(moveInput * speed, rb.velocity.y);
        }
        
    }

    private void Update()
    {
        if (isGrounded)
        {
            canJump = true;
        }

        if (Input.GetKeyDown(KeyCode.W) && canJump == true && isGrounded == true)
        {
            if (rb.bodyType == RigidbodyType2D.Dynamic)
            {
                rb.velocity = Vector3.up * jumpForce;
            }
            else Debug.Log("Cannot affect static rigidbody");
        }
        canJump = false;
    }

    private void ontr (Collision2D collision)
    {
        canJump = true;
    }
}
