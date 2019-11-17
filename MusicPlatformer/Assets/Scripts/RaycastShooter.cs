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

    public Object GetObjectHit()
    {
        diff = shotPoint.transform.position - arrow.transform.position;
        RaycastHit2D hit = Physics2D.Raycast(arrow.transform.position, diff, Mathf.Infinity);
        if (hit)
        {
            
            //sets object hit to objectHit variable
            objectHit = hit.transform.gameObject.GetComponent<Object>();
            //finds the distance of the raycast with a multiplier
            float distance = hit.distance * 2.5f;
            //debugs the name of object hit
            Debug.Log(hit.transform.gameObject.name);
            //draws ray for visual purposes
            Debug.DrawRay(arrow.transform.position, diff * distance, Color.blue, 0.5f);
            return objectHit;
        }
        Debug.Log("No object hit");
        return null;
    }
}
