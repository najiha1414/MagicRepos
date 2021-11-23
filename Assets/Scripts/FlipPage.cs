using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FlipPage : MonoBehaviour
{
    private enum ButtonType
    {
        NextButton,
        PrevButton
    }

    [SerializeField] Button nextBtn;
    [SerializeField] Button prevBtn;

    private Vector3 rotationVector;
    private Vector3 startPosition;
    private Quaternion startRotation;
    private bool isClicked;
    private DateTime startTime;
    private DateTime endTime;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
        startPosition = transform.position;

        if (nextBtn != null)
        nextBtn.onClick.AddListener(() => turnOnePageBtn_Click(ButtonType.NextButton));

        if (nextBtn != null)
        nextBtn.onClick.AddListener(() => turnOnePageBtn_Click(ButtonType.PrevButton));
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
        {
            transform.Rotate(rotationVector * Time.deltaTime);
            endTime = DateTime.Now;

            if ((endTime - startTime).TotalSeconds >= 1)
            {
                isClicked = false;
                transform.rotation = startRotation;
                transform.position = startPosition;
            }
        }
    }

    private void turnOnePageBtn_Click(ButtonType type)
    {
        isClicked = true;
        startTime = DateTime.Now;

        if (type == ButtonType.NextButton)
        {
            rotationVector = new Vector3(0, 180, 0);
        }

        else if (type == ButtonType.PrevButton)
        {
            rotationVector = new Vector3(0, -180, 0);
        }
    }
}
