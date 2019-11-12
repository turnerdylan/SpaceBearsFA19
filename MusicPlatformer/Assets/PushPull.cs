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

    private void Start()
    {
        rs = GetComponentInChildren<RaycastShooter>();
    }

    // Update is called once per frame
    void Update()
    {
        playerTransform = transform.position;
        
        if (Input.GetKey(KeyCode.E) )
        {
            if (GetObject())
            {
                rb.velocity = offset * moveSpeed;
                rb.gravityScale = 0;
            }
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            if (GetObject())
            {
                rb.velocity = -offset * moveSpeed;
                rb.gravityScale = 0;
            }
        }
        else
        {
            rb.gravityScale = 1;
        }

    }

    bool GetObject()
    {
        testObject = rs.GetObjectHit();
        if (testObject)
        {
            objectTransform = testObject.transform.position;
            offset = objectTransform - playerTransform;
            offset.Normalize();
            if (testObject.GetComponent<Rigidbody2D>() != null)
            {
                Debug.Log("hit an object!");
                rb = testObject.GetComponent<Rigidbody2D>();
                return true;
            }
        }
        return false;
    }
}
