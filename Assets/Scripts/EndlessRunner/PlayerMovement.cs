using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;

    public float speed = 5;
    [SerializeField] Rigidbody rb;

    private float horizontalInput;
    [SerializeField] float horizontalMultiplier = 2;

    public float speedIncreasePerPoint = 0.1f;

    [SerializeField] float jumpForce = 400f;
    [SerializeField] LayerMask groundMask;
    
    public OnDie deathMenu;
    private float score;

    
    private void FixedUpdate() 
    {
        if (!alive) return; //if the variable alive is not true, so running the function

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime; //the player going forward
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);    
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //to make the player jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        //to get the position of player
        if(transform.position.y < -5)
        {
            Die();
        }

        if(alive)
        return;
    }

    public void Die() 
    {
        alive = false;
        deathMenu.ToggleEndMenu(score); //to make the black death menu popup

        //Restart game with a delay after 2secs
        //Invoke("Restart", 2); 

        //every time the player collide with the collision, the game is running but restarting
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // void Restart()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    // }

    void Jump()
    {
        //check whether we are currently grounded
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height/2) + 0.1f, groundMask);

        //if we are grounded, jump
        rb.AddForce(Vector3.up * jumpForce);
    }
}
