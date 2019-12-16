using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFreeze : MonoBehaviour
{
    Vector3 storedVelocity;
    RaycastShooter rs;
    Object testObject;
    Rigidbody2D rb;
    PlayerController1 pc;

    // Start is called before the first frame update
    void Start()
    {
        rs = GetComponentInChildren<RaycastShooter>();
        pc = GetComponent<PlayerController1>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Raycast1player" + pc.joystickNum))
        {
            if (GetObject())
            {
                if (testObject.GetComponent<Rigidbody2D>())
                {
                    rb = testObject.GetComponent<Rigidbody2D>();
                }
                else
                {
                    return;
                }

                pc.TauntTrigger();
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
                StartCoroutine(delay());
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

    IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        rs.ClearLines();
    }
}
