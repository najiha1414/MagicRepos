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

    public void staffsProfile()
    {
        SceneManager.LoadScene("HCStaffsProfile");
    }
    
    public void BackDepartmentsScene()
    {
        SceneManager.LoadScene("Departments");
    }
}
