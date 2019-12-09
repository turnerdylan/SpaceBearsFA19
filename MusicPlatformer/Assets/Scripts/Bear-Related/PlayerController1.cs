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

    public AudioSource Jump;
    public AudioSource Walk;

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
        StartCoroutine(PlayFootstepSound());
    }

    private void Update()
    {
        //string joystickString = joystickNum.ToString();
        if(Input.GetJoystickNames().Length > 0)
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
                rb.velocity = Vector3.up * jumpForce;
                Jump.Play();
                Walk.Stop();
            }
            isGrounded = false;
        }
        else
        {
            Debug.Log("no controller");
        }



    }

    private IEnumerator PlayFootstepSound()
    {
        while (true)
        {
            if (moveInput > 0 || moveInput < 0)
            {
                Walk.Play();
            }

            yield return new WaitForSeconds(0.3f);// Play with this value a bit.
        }
    }
}
