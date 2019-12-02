using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private bool isPressed = false;
    public Sprite unpressed;
    public Sprite pressed;
    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = unpressed;
    }

    // Update is called once per frame
    void Update()
    {
        isPressed = false;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isPressed = true;
        sr.sprite = pressed;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isPressed = false;
        sr.sprite = unpressed;
    }
}
