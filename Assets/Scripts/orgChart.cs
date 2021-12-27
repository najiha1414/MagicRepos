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

    public void DBStaffsProf()
    {
        SceneManager.LoadScene("DBStaffsProfile");
    }

    public void DB2StaffsProf()
    {
        SceneManager.LoadScene("DB2StaffsProfile");
    }

    public void ActuStaffsProf()
    {
        SceneManager.LoadScene("ActuarialStaffsProfile");
    }

    public void FinanceStaffsProf()
    {
        SceneManager.LoadScene("FinanceStaffsProfile");
    }

    public void PartnerStaffsProf()
    {
        SceneManager.LoadScene("PartnerStaffsProfile");
    }

    public void CEOStaffsProf()
    {
        SceneManager.LoadScene("CEOStaffsProfile");
    }
    
    public void BackDepartmentsScene()
    {
        SceneManager.LoadScene("Departments");
    }
}
