using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{    
    public GameObject Panel;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

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
        Application.Quit();
        Debug.Log("QUIT!");           
    }
}
