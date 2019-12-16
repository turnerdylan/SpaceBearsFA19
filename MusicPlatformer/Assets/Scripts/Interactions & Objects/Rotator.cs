using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    Object obj;
    public bool sin = true;
    public float rotateSpeed = 2f;
    public float maxRotation = 45;
    float offset;
    Vector3 pos;

    private void Start()
    {
        obj = GetComponent<Object>();
        offset = Random.Range(0, 5);
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos;
        if (!obj.isFrozen && sin)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, maxRotation * Mathf.Sin((Time.time * rotateSpeed) + offset));
        }
        else
        {
            transform.Rotate(0, 0, -5);
        }
    }
}
