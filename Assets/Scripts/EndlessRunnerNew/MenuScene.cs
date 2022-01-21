using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour
{
    public Text highscoreText;

    void Start() 
    {
        highscoreText.text = "Highscore: " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString(); //fetch the highscore from Registry Editor
    }

    public void ToGame()
    {
        SceneManager.LoadScene("EndlessRunnerNew");
    }

    public void ToMagic()
    {
        SceneManager.LoadScene("Magic");
    }
}
