using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPull : MonoBehaviour
{
    Object testObject;
    RaycastShooter rs;
    Vector3 playerTransform;
    Vector3 objectTransform;
    Vector3 offset;
    Rigidbody2D rb;
    public float moveSpeed;
    PlayerController1 pc;

    private void Start()
    {
        rs = GetComponentInChildren<RaycastShooter>();
        pc = GetComponent<PlayerController1>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerTransform = transform.position;

        if (Input.GetButton("Raycast1player" + pc.joystickNum) )
        {
            if (GetObject())
            {
                GetOffset();
                if(rb.bodyType != RigidbodyType2D.Static)
                {
                    rb.velocity = offset * moveSpeed;
                    rb.gravityScale = 0;
                    testObject.isBeingPushed = true;
                    
                }
            }
        }
        else if (Input.GetButton("Raycast2player" + pc.joystickNum))
        {
            if (GetObject())
            {
                GetOffset();
                if (rb.bodyType != RigidbodyType2D.Static)
                {
                    rb.velocity = -offset * moveSpeed;
                    rb.gravityScale = 0;
                    testObject.isBeingPushed = true;
                    /*if (!pc.GetTaunt())
                    {
                        pc.TauntControl(true);
                    }*/
                }
            }
        }
        else
        {
            //pc.TauntControl(false);
            rs.ClearLines();
        }

    }

    void GetOffset()
    {
        objectTransform = testObject.transform.position;
        offset = objectTransform - playerTransform;
        offset.Normalize();
        rb = testObject.GetComponent<Rigidbody2D>();
    }

    bool GetObject()
    {
        testObject = rs.GetObjectHit();
        if (testObject)
        {
            return true;
        }
        return false;

    }
}
