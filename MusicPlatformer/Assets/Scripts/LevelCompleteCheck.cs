using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteCheck : MonoBehaviour
{
    bool p1check = false;
    bool p2check = false;
    bool p3check = false;

    LevelLoader ll;

    // Start is called before the first frame update
    void Start()
    {
        ll = FindObjectOfType<LevelLoader>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var lay = collision.gameObject.layer;
        if (lay == 8) p1check = true;
        if (lay == 9) p2check = true;
        if (lay == 10) p3check = true;

        Debug.Log("p1" + p1check);
        Debug.Log("p2" + p2check);
        Debug.Log("p3" + p3check);

        if (p1check && p2check && p3check) ll.LoadNextScene();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var lay = collision.gameObject.layer;
        if (lay == 8) p1check = false;
        if (lay == 9) p2check = false;
        if (lay == 10) p3check = false;
    }
}
