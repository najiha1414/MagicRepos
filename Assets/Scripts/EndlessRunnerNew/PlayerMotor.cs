using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    Rigidbody rb;

    private float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;

    private float animationDuration = 3.0f;
    private float startTime;

    private bool isDead = false;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        startTime = Time.time;
    }

    void Update()
    {
        if(isDead)
            return;

        if(Time.time - startTime < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }

        moveVector = Vector3.zero;

        if(controller.isGrounded) //if i am on the floor
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        //X = left right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

        //Y = up down
        moveVector.y = verticalVelocity;

        //Z = forward backward (the player goes forward)
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime); //we want to go forward all the time
    }

    //connected with Score.cs
    public void SetSpeed(float modifier) 
    {
        speed = 5.0f + modifier;
    }


    //it is being called every time our capsule/player hits something (Death condition)
    //every time the capsule's collider HITS the objects' collider, player dead
    private void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        if(hit.gameObject.tag == "Enemy")
            Death();
    }

    private void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}
