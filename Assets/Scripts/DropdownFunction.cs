using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownFunction : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

    public void DropdownFunctioning(int value)
    {
        if(value == 0)
        {
            image1.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);

        }

        if(value == 1)
        {
            image1.SetActive(true);
            image2.SetActive(false);
            image3.SetActive(false);

        }

        if(value == 2)
        {
            image1.SetActive(false);
            image2.SetActive(true);
            image3.SetActive(false);

        }

        if(value == 3)
        {
            image1.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(true);

        }
    }
}
