using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    Vector3 currentScale;

    Vector3 smallScale;
    Vector3 largeScale;

    float scaleSpeed = 3f;
    bool isFrozen;


    // Start is called before the first frame update
    void Start()
    {
        currentScale = transform.localScale;
        smallScale = currentScale / 2;
        largeScale = currentScale * 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            //transform.localScale = Vector3.Lerp(transform.localScale, largeScale, scaleSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.Q))
        {
            //transform.localScale = Vector3.Lerp(transform.localScale, smallScale, scaleSpeed * Time.deltaTime);
        }
    }
}
