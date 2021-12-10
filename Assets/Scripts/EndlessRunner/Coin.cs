using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float turnSpeed = 90f; //coin rotation

    public GameObject effect;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
        }

        if (other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }

        //check the object we collided with is the player
        if (other.gameObject.name != "Player")
        {
            return;
        }

        //add to the player's score
        GameManager.inst.IncrementScore();

        //destroy the coin
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime); //rotate coin along z-axis by 90 degrees every secs
    }
}
