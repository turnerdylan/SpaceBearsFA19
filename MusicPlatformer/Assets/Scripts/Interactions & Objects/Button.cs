using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool isPressed;
    public Sprite unpressed;
    public Sprite pressed;
    SpriteRenderer sr;
    public GameObject interaction;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = unpressed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        interaction.GetComponent<Animation>().Play("Anim1");
        isPressed = true;
        sr.sprite = pressed;
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        interaction.GetComponent<Animation>().Play("Anim2");
        isPressed = false;
        sr.sprite = unpressed;
    }
}
