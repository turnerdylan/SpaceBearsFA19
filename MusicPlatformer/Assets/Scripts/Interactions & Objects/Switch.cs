using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    bool switchState = false;
    public GameObject interaction;
    public Sprite unpressed;
    public Sprite pressed;
    SpriteRenderer sr;

    public float moveDistance = 50;

    public AudioSource SwitchSFX;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = unpressed;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            switchState = !switchState;
            if (switchState)
            {
                sr.sprite = pressed;
                interaction.GetComponent<Animation>().Play("Anim1");
                SwitchSFX.Play();
            }
            else
            {
                sr.sprite = unpressed;
                interaction.GetComponent<Animation>().Play("Anim2");
                SwitchSFX.Play();
            }
        }
    }
}
