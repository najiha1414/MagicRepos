using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class orgChart : MonoBehaviour
{
    public void orgChartGame()
    {
        SceneManager.LoadScene("OrgChart");
    }

    public void HCStaffsProf()
    {
        SceneManager.LoadScene("HCStaffsProfile");
    }

    public void ITStaffsProf()
    {
        SceneManager.LoadScene("ITStaffsProfile");
    }
    
    public void BackDepartmentsScene()
    {
        SceneManager.LoadScene("Departments");
    }
}
