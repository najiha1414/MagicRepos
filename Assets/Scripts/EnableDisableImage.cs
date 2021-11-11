using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableImage : MonoBehaviour
{
    public GameObject img;
    
    public void whenButtonClicked()
    {
        if (img.activeInHierarchy == true)
        img.SetActive(false);
        else
        img.SetActive(true);
    }
}
