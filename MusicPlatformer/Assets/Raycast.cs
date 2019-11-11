using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 playerPos;
    Vector3 diff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = transform.position;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        diff = playerPos - mousePos;
        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space pressed");
            if(Physics.Raycast(playerPos, diff, out hit, Mathf.Infinity))
            {
                Debug.Log("ray fired");
                Debug.DrawRay(playerPos, diff * hit.distance, Color.red);
            }
            
        }
    }
}
