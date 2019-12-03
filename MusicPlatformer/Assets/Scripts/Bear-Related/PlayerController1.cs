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
    private Animator anim;

    bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    bool canJump;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");

        if(moveInput > 0)
        {
            anim.SetInteger("Run", 1);
        } else if(moveInput < 0)
        {
            anim.SetInteger("Run", 2);
        }
        else
        {
            anim.SetInteger("Run", 0);
        }
        if (rb.bodyType == RigidbodyType2D.Dynamic)
        {
            rb.velocity = new Vector3(moveInput * speed, rb.velocity.y);
        }


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        {
            if (rb.bodyType == RigidbodyType2D.Dynamic)
            {
                if (moveInput >= 0)
                {
                    anim.SetTrigger("JumpR");
                }
                else if (moveInput < 0)
                {
                    anim.SetTrigger("JumpL");
                }
                rb.velocity = Vector3.up * jumpForce;
            }
            else Debug.Log("Cannot affect static rigidbody");
        }
        isGrounded = false;
    }
}
