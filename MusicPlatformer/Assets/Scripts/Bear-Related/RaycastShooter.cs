using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooter : MonoBehaviour
{
    //indicator where raycast spawns
    public GameObject arrow;

    //where raycast is shot at
    public GameObject shotPoint;

    //object that is hit
    Object objectHit;

    //the offset bw the two transforms, gets the direction of the raycast
    Vector3 diff;
    RaycastHit2D hit;
    public LayerMask canHit;

    //////line rendering

    LineRenderer laser;
    float laserWidth = 0.1f;
    float laserMaxLength = 20f;

    private void Start()
    {
        laser = GetComponent<LineRenderer>();
        Vector3[] initLaserPositions = new Vector3[2] { Vector3.zero, Vector3.zero };
        laser.SetPositions(initLaserPositions);
        laser.startWidth = laserWidth;
        laser.endWidth = laserWidth;
    }

    public Object GetObjectHit()
    {
        Vector3 endPosition = transform.position + (laserMaxLength * diff);
        diff = shotPoint.transform.position - arrow.transform.position;
        hit = Physics2D.Raycast(arrow.transform.position, diff, Mathf.Infinity, canHit);
        if (hit)
        {
            laser.enabled = true;
            endPosition = hit.point;
            //sets object hit to objectHit variable
            objectHit = hit.transform.gameObject.GetComponent<Object>();

            //draws ray for visual purposes
            //Debug.DrawRay(arrow.transform.position, diff * hit.distance * 2.5f, Color.blue, 0.5f);
            laser.SetPosition(0, transform.position);
            laser.SetPosition(1, endPosition);
            return objectHit;
        }
        laser.enabled = false;
        Debug.Log("No object hit");
        return null;
    }

    public bool TestForObject()
    {
        if(Physics2D.Raycast(arrow.transform.position, diff, Mathf.Infinity, canHit))
        {
            return true;
        }
        return false;
    }
}
