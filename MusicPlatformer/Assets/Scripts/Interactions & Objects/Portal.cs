using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Portal otherPortal;
    bool canTeleport = true;
    ParticleSystem ps;
    //ParticleSystem.MainModule mm;
    public float resetTime = 3f;
    public float rotateSpeed;

    public AudioSource PortalSFX;

    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
        //mm = ps.main;
    }

    private void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canTeleport)
        {
            collision.gameObject.transform.position = otherPortal.transform.position;
            otherPortal.canTeleport = false;
            PortalSFX.Play();
            //mm.startColor = new Color(90, 90, 90, 255);
            StartCoroutine(delay());
        }
    }

      
    IEnumerator delay()
    {
        yield return new WaitForSeconds(resetTime);
        otherPortal.canTeleport = true;
        //mm.startColor = new Color(250, 226, 226, 255);

    }

}
