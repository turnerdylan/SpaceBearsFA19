using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody rb;

    /*private bool isGrounded;
    public Transform groundsCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    Collider [] overlap;*/
    bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //isGrounded =
        /*overlap = Physics.OverlapSphere(groundsCheck.position, checkRadius, whatIsGround);
        for(int i=0; i<overlap.Length; i++)
        {
            if (!overlap[i])
            {
                isGrounded = false;
            }
        }*/

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(moveInput * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            rb.velocity = Vector3.up * jumpForce;
            
        }
        canJump = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        canJump = true;
    }
}
