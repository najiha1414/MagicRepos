using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public GameObject effect;

    private void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime); //Time.deltaTime = just to make sure the player moves at the same speed on all kinds of comps

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            //transform.position = targetPos;
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            //transform.position = targetPos;
        }
    }
}
