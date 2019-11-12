using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFreeze : MonoBehaviour
{
    Vector3 storedVelocity;
    RaycastShooter rs;
    Object testObject;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rs = GetComponentInChildren<RaycastShooter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (testObject = rs.GetObjectHit())
            {
                if (testObject.GetComponent<Rigidbody2D>())
                {
                    Debug.Log("hit an object!");
                    rb = testObject.GetComponent<Rigidbody2D>();
                }
                else
                {
                    return;
                }

                if (!testObject.isFrozen)
                {
                    storedVelocity = rb.velocity;
                    //rb.velocity = Vector2.zero;
                    rb.bodyType = RigidbodyType2D.Static;
                    testObject.isFrozen = true;
                }
                else if (testObject.isFrozen)
                {
                    rb.bodyType = RigidbodyType2D.Dynamic;
                    rb.velocity = storedVelocity;
                    testObject.isFrozen = false;
                }
            }    
        }
    }
}
