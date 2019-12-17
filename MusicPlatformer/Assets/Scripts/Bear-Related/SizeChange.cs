using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    Object testObject;
    RaycastShooter rs;
    PlayerController1 pc;

    // Start is called before the first frame update
    void Start()
    {
        rs = GetComponentInChildren<RaycastShooter>();
        pc = GetComponent<PlayerController1>();
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Raycast1player" + pc.joystickNum))
        {
            if (GetObject() && testObject.canBeSized)
            {
                //pc.TauntControl(true);
                testObject.transform.localScale = Vector3.Lerp(testObject.transform.localScale, testObject.GetLargeScale(), testObject.GetScaleSpeed() * Time.deltaTime);
            }
        }
        else if (Input.GetButton("Raycast2player" + pc.joystickNum))
        {
            if (GetObject() && testObject.canBeSized)
            {
                //pc.TauntControl(true);
                testObject.transform.localScale = Vector3.Lerp(testObject.transform.localScale, testObject.GetSmallScale(), testObject.GetScaleSpeed() * Time.deltaTime);
            }
        }
        else
        {
            rs.ClearLines();
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
