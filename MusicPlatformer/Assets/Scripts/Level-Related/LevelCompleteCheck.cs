using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteCheck : MonoBehaviour
{
    bool p1check = false;
    bool p2check = false;
    bool p3check = false;

    LevelLoader ll;
    public Sprite doorOpen;
    SpriteRenderer sr;

    public AudioSource Victory;

    // Start is called before the first frame update
    void Start()
    {
        ll = FindObjectOfType<LevelLoader>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var lay = collision.gameObject.layer;
        if (lay == 8) p1check = true;
        if (lay == 9) p2check = true;
        if (lay == 10) p3check = true;

        if (p1check && p2check && p3check)
        {
            sr.sprite = doorOpen;
            StartCoroutine(delay());
            Victory.Play();
        } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var lay = collision.gameObject.layer;
        if (lay == 8) p1check = false;
        if (lay == 9) p2check = false;
        if (lay == 10) p3check = false;
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2);
        ll.LoadNextScene();
    }
}
