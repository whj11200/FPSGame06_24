using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    public Light ONE;
    public  AudioSource sours;
    public AudioClip On;
    public AudioClip Off;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ONE.enabled = true;
            sours.PlayOneShot(On,1.0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ONE.enabled = false;
            sours.PlayOneShot(Off, 1.0f);
        }
    }
    void Update()
    {
        
    }
}
