using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float moveHorizontal;

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
        //StartCoroutine(PlayFootstepSound());
    }

    private void Update()
    {
        moveHorizontal = Input.GetAxis("XaxisPlayer" + joystickNum);


        //string joystickString = joystickNum.ToString();
        if(Input.GetJoystickNames().Length > 0)
        {
            for(int i=0; i< Input.GetJoystickNames().Length; i++)
            {
                Debug.Log("i is " + i + "   name is: " + Input.GetJoystickNames()[i]);
            }


            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

            //handles jump
            if (Input.GetButtonDown("JumpPlayer" + joystickNum) && isGrounded == true)
            {
                Debug.Log("joystick is: " + joystickNum);
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
                Jump.Play();
                Walk.Stop();
            }
            isGrounded = false;

            //handles walking
            //aniamtions
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
        }
        else
        {
            Debug.Log("no controller");
        }        
    }
}

    /*private IEnumerator PlayFootstepSound(float moveHorizontal)
    {
        while (true)
        {
            if (moveHorizontal > 0 || moveHorizontal < 0)
            {
                Walk.Play();
            }

            yield return new WaitForSeconds(0.3f);// Play with this value a bit.
        }
    }*/
