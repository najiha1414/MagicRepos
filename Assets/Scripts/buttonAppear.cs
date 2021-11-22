using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonAppear : MonoBehaviour
{
    public GameObject btnConsole;
    public GameObject btnConsole2;

    public void departmentsGame()
    {
        SceneManager.LoadScene("Departments");
    }

    public void generalInfoGame()
    {
        SceneManager.LoadScene("GeneralInfo");
    }

    public void booksGame()
    {
        SceneManager.LoadScene("Books");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        btnConsole.SetActive(false);
        btnConsole2.SetActive(false);
    }

    void OnTriggerEnter(Collider other) {
        btnConsole.SetActive(true);
        btnConsole2.SetActive(true);
    }

    void OnTriggerExit(Collider other) {
        btnConsole.SetActive(false);
        btnConsole2.SetActive(false);
    }
}
