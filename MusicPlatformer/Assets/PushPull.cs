using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPull : MonoBehaviour
{
    public GameObject testObject;
    Vector3 playerTransform;
    Vector3 objectTransform;
    Rigidbody2D rb;

    private void Start()
    {
        rb = testObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerTransform = transform.position;
        objectTransform = testObject.transform.position;
        Vector3 offset = objectTransform - playerTransform;

        if (Input.GetKey(KeyCode.Q))
        {
            rb.velocity = offset;
            rb.gravityScale = 0;
        } else if (Input.GetKey(KeyCode.E))
        {
            rb.velocity = -offset;
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 1;
        }
        

        
    }
}
