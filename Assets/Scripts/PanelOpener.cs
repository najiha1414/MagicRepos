using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject tooltip;

    public void ShowTooltip()
    {
        if (tooltip != null)
        {
            bool isActive = tooltip.activeSelf;
            tooltip.SetActive(!isActive);
        }
    }
}
