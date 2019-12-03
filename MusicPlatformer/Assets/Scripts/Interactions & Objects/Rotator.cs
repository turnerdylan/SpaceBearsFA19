using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    Object obj;
    public float rotateSpeed = 2f;
    public float maxRotation = 45;
    float offset;

    private void Start()
    {
        obj = GetComponent<Object>();
        offset = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (!obj.isFrozen)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, maxRotation * Mathf.Sin((Time.time * rotateSpeed) + offset));
        }
    }
}
