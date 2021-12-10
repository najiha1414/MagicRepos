using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision) 
    {
        //to declare its the player that do the collision
        if (collision.gameObject.name == "Player")
        {
            //when we know the player did the collision against obstacle, the player die
            playerMovement.Die();
        }
    }
}
