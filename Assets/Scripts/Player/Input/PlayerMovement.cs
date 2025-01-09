using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /* 
  Create a variable called 'rb' that will represent the 
  rigid body of this object.
  */
    private Rigidbody rb;
    public float moveSpeed;
    //public AudioSource footStepSoundSource;
    /* 
    Creates a public variable that will be used to set 
    the movement intensity (from within Unity)
    */

    //void playAudio()
    //{
    //    if (!footStepSoundSource.isPlaying)
    //    {
    //        footStepSoundSource.Play();
    //    }
    //}

    void Start()
    {
        // make our rb variable equal the rigid body component
        rb = GetComponent<Rigidbody>();
        //footStepSoundSource = GetComponent<AudioSource>();
        // yPos = transform.position.y;
    }

    void Update()
    {
        // Move Forwards
        if (Input.GetKey(KeyCode.W))
        {
           // playAudio();
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        // Move Backwards
        else if (Input.GetKey(KeyCode.S))
        {
          //  playAudio();
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
        }
        // Move Left
        else if (Input.GetKey(KeyCode.A))
        {
           // playAudio();
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }
        // Move Right
        else if (Input.GetKey(KeyCode.D))
        {
           // playAudio();
            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
