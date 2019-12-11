using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    LineRenderer laser;
    float laserWidth = 0.1f;
    float laserMaxLength = 20f;

    RaycastHit2D hit;
    public LayerMask canHit;
    public Vector3 direction;
    public Transform reSpawn;

    // Start is called before the first frame update
    void Start()
    {
        laser = GetComponent<LineRenderer>();
        Vector3[] initLaserPositions = new Vector3[2] { Vector3.zero, Vector3.zero };
        laser.SetPositions(initLaserPositions);
        laser.startWidth = laserWidth;
        laser.endWidth = laserWidth;
        laser.enabled = true;
        laser.startColor = Color.red;
        laser.endColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(transform.position, direction, Mathf.Infinity, canHit);
        Vector3 endPosition = transform.position + (laserMaxLength * direction);
        endPosition = hit.point;
        laser.SetPosition(0, transform.position);
        laser.SetPosition(1, endPosition);
        var layer = hit.collider.gameObject.layer;
        if ( layer == 8 || layer == 9 || layer == 10)
        {
            hit.collider.gameObject.transform.position = reSpawn.position;
        }
    }
}
