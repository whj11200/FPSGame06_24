using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAni : MonoBehaviour
{
    public Animation Animation;
    public Light GunLight;
    public AudioSource ONE;
    public AudioClip TWO;
    void Start()
    {
        
    }


    void Update()
    {
        Move();
        Flash();

    }

    private void Flash()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GunLight.enabled = !GunLight.enabled;
            ONE.PlayOneShot(TWO, 0.5f);
        }
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W)))
        {
            Animation.Play("running");
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Animation.Play("runStop");
        }
    }
}
