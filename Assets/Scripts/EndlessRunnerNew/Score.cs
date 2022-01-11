using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float score = 0.0f;
    
    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;

    private bool isDead = false;

    public Text scoreText;
    public DeathMenu deathMenu;

    void Update()
    {
        if(isDead) 
            return; //when player dead, the score is stopped too

        if(score >= scoreToNextLevel)
            LevelUp();

        score += Time.deltaTime * difficultyLevel; //got score every secs
        scoreText.text = ((int)score).ToString();
    }

    //we're going to level up if we passed the score
    void LevelUp()
    {
        if(difficultyLevel == maxDifficultyLevel)
            return;

        scoreToNextLevel *= 2; //10x2=20 multiply by 2
        difficultyLevel++;

        //player speed increment when keep running
       GetComponent<PlayerMotor>().SetSpeed(difficultyLevel); //get the SetSpeed from PlayerMotor.cs using GetComponent method
    
        Debug.Log(difficultyLevel);
    }

    public void OnDeath()
    {
        isDead = true;

        //setting highscore for player prefs
        //can see highscore at Registry Editor in Windows and search for Current User-Software-Etiqa-Magic
        if(PlayerPrefs.GetFloat("Highscore") < score)
            PlayerPrefs.SetFloat("Highscore", score);
        
        deathMenu.ToggleEndMenu(score);
    }
}
