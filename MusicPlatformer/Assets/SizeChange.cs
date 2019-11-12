using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    Object testObject;
    RaycastShooter rs;

    // Start is called before the first frame update
    void Start()
    {
        rs = GetComponentInChildren<RaycastShooter>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            if (GetObject())
            {
                testObject.transform.localScale = Vector3.Lerp(testObject.transform.localScale, testObject.GetLargeScale(), testObject.GetScaleSpeed() * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.I))
        {
            if (GetObject())
            {
                testObject.transform.localScale = Vector3.Lerp(testObject.transform.localScale, testObject.GetSmallScale(), testObject.GetScaleSpeed() * Time.deltaTime);
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
