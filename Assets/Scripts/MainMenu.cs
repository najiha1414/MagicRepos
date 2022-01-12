using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{    
    // SavePlayerPos playerPosData;

    // void Start()
    // {
    //     playerPosData = FindObjectOfType<SavePlayerPos>();
    // }
       
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StorylineGame()
    {
        SceneManager.LoadScene("Storyline");
    }

    public void BackGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BackMagicGame()
    {
        SceneManager.LoadScene("Magic");
    }

    public void QuitGame()
    {
        //playerPosData.PlayerPosSave();
        Application.Quit();
        Debug.Log("QUIT!");           
    }
}
