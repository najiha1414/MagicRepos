using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;

    [SerializeField] Text scoreText;
    [SerializeField] PlayerMovement playerMovement;

    public void IncrementScore()
    {
        score++;
        scoreText.text = " " + score;

        //increase player's speed
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }

    //connected with Coin.cs which is incrementing the player's score after player enter the coins collider
    private void Awake() 
    {
        inst = this;
    }
}
