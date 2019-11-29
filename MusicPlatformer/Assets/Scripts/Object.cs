using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    Vector3 currentScale;
    Vector3 smallScale;
    Vector3 largeScale;
    float scaleSpeed = 5f;

    Rigidbody2D rb;

    public bool isFrozen = false;
    public bool isBeingPushed = false;
    public float currentGravityScale = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentScale = transform.localScale;
        smallScale = currentScale / 2;
        largeScale = currentScale * 2;
    }

    private void Update()
    {
        rb.gravityScale = currentGravityScale;
    }

    public Rigidbody2D CheckForRB()
    {
        return rb;
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
