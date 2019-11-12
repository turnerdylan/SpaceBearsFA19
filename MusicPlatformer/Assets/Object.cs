using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    Vector3 currentScale;

    Vector3 smallScale;
    Vector3 largeScale;

    float scaleSpeed = 3f;
    public bool isFrozen = false;


    // Start is called before the first frame update
    void Start()
    {
        currentScale = transform.localScale;
        smallScale = currentScale / 2;
        largeScale = currentScale * 2;
    }

    public Vector3 GetLargeScale()
    {
        return largeScale;
    }

    public Vector3 GetSmallScale()
    {
        return smallScale;
    }

    public float GetScaleSpeed()
    {
        return scaleSpeed;
    }

}
