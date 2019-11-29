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
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (GetObject())
            {
                Debug.Log("object hit is " + testObject.name);
                if (testObject.GetComponent<Rigidbody2D>())
                {
                    rb = testObject.GetComponent<Rigidbody2D>();
                }
                else
                {
                    return;
                }

                if (!testObject.isFrozen)
                {
                    storedVelocity = rb.velocity;
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
