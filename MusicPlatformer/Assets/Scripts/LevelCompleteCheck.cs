using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteCheck : MonoBehaviour
{
    PlayerController1 p1;
    PlayerController1 p2;
    PlayerController1 p3;

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
        ll.LoadNextScene();
    }
}
