using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.position = spawnPoint.position;
    }
}
