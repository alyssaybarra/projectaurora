using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variables
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.8f;

    public Transform groundCheck;
    public float groundDistance = .4f;
    public LayerMask groundMask; 

    //private variables
    Vector3 velocity;
    bool isGrounded; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        //creates an invisible sphere around the player that checks if the player is on the ground. 
        //if anything collides with the circle than isGrounded is going to be true. 
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        //allows to get the default inputs from unity
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //allows the player controller to move based on the character controller
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //applies gravity to the player controller
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        
    }
}
