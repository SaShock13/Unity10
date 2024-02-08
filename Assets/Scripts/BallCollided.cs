using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollided : MonoBehaviour
{
   
    AudioSource sound;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        sound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!sound.isPlaying)
        {
            sound.Play();
        }
    }
}
