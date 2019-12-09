using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public float offset = 180;

    PlayerController1 pc;

    private void Start()
    {
        pc = GetComponentInParent<PlayerController1>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);*/
        int player = pc.joystickNum;


        transform.eulerAngles = new Vector3(0, 0, offset + Mathf.Atan2(Input.GetAxis("LookXPlayer" + player), Input.GetAxis("LookYPlayer" + player)) * 180 / Mathf.PI );
    }
}
