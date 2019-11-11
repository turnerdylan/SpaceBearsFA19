using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFreeze : MonoBehaviour
{
    Vector3 storedVelocity;
    public GameObject testObject;
    Rigidbody rb;
    bool isFrozen = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = testObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isFrozen)
            {
                storedVelocity = rb.velocity;
                rb.isKinematic = true;
                isFrozen = true;
            }
            else if(isFrozen)
            {
                rb.isKinematic = false;
                rb.velocity = storedVelocity;
                isFrozen = false;
            }
            
        }
    }
}
