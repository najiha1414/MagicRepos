using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Text scoreText;
    
    public Image bgImage; //animation for bgimage after death
    private bool isShown = false;
    private float transition = 0.0f;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if(!isShown)
        return;

        transition += Time.deltaTime;
        bgImage.color = Color.Lerp(new Color(0,0,0,0), Color.black, transition);
    }

    public void ToggleEndMenu(float score) //score is the parameter
    {
        gameObject.SetActive(true); //the death menu UI pops up
        scoreText.text = ((int)score).ToString(); //the score you played pops up after dying/hitting the obstacles collider
        isShown = true;
    }

    public void Restart()
    {
        //when press Play button, it bots our scene over again
        //reload our game scene with new score, new random obstacles
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ToMenu()
    {
        //when press Play button, it bots our scene over again
        SceneManager.LoadScene("RunnerMenuScene"); 
    }

    public void ToMagic() 
    {
        SceneManager.LoadScene("Magic");
    }
}
