using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    bool switchState = false;
    public GameObject door;
    public Sprite unpressed;
    public Sprite pressed;
    SpriteRenderer sr;

    public float moveDistance = 50;

    private void Start()
    {
        sr.sprite = unpressed;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("open door");
            switchState = !switchState;
            if (switchState)
            {
                gameObject.transform.Rotate(0, 0, -90);
                door.transform.position = Vector3.Lerp(door.transform.position, door.transform.position + new Vector3(0, 5, 0), 1);
            }
            else
            {
                gameObject.transform.Rotate(0, 0, 90);
                door.transform.position = Vector3.Lerp(door.transform.position, door.transform.position - new Vector3(0, 5, 0), 1);
            }
        }

    }
}
