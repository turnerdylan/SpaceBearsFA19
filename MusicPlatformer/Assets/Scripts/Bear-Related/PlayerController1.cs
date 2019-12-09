using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Mirror;

public class PlayerController1 : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveHorizontal;

    private Rigidbody2D rb;
    private Animator anim;

    bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public int joystickNum;

    bool canJump;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //string joystickString = joystickNum.ToString();
        if(Input.GetJoystickNames().Length > 0)
        {
            for(int i=0; i < Input.GetJoystickNames().Length; i++)
            {
                Debug.Log("i is: " + i);
                Debug.Log("input is: " + Input.GetJoystickNames()[i]);
            }
            moveHorizontal = Input.GetAxis("XaxisPlayer" + joystickNum);
            Debug.Log(Input.GetAxis("XaxisPlayer1"));

            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

            if (moveHorizontal > 0.1)
            {
                anim.SetInteger("Run", 1);
            }
            else if (moveHorizontal < -0.1)
            {
                anim.SetInteger("Run", 2);
            }
            else
            {
                anim.SetInteger("Run", 0);
            }
            if (rb.bodyType == RigidbodyType2D.Dynamic)
            {
                rb.velocity = new Vector3(moveHorizontal * speed, rb.velocity.y);
            }

            if (Input.GetButtonDown("JumpPlayer" + joystickNum) && isGrounded == true)
            {
                if (rb.bodyType == RigidbodyType2D.Dynamic)
                {
                    if (moveHorizontal >= 0)
                    {
                        anim.SetTrigger("JumpR");
                    }
                    else if (moveHorizontal < 0)
                    {
                        anim.SetTrigger("JumpL");
                    }
                    rb.velocity = Vector3.up * jumpForce;
                }
                else Debug.Log("Cannot affect static rigidbody");
            }
            isGrounded = false;
        }
        else
        {
            Debug.Log("no controller");
        }


        
    }
}
