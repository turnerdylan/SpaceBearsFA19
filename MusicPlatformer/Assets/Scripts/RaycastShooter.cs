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

    public Object GetObjectHit()
    {
        diff = shotPoint.transform.position - arrow.transform.position;
        hit = Physics2D.Raycast(arrow.transform.position, diff, Mathf.Infinity, canHit);
        if (hit)
        {
            //sets object hit to objectHit variable
            objectHit = hit.transform.gameObject.GetComponent<Object>();

            //draws ray for visual purposes
            Debug.DrawRay(arrow.transform.position, diff * hit.distance * 2.5f, Color.blue, 0.5f);
            return objectHit;
        }
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
