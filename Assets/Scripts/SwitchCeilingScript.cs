using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SwitchCeilingScript : MonoBehaviour
{
    [SerializeField] private GameObject XROrigin;
    private InputData _inputData;
    private bool lastButtonState = false;

    void Start()
    {
        _inputData = XROrigin.GetComponent<InputData>();
        Debug.Log(_inputData);
    }

    void Update()
    {
        bool tempState = false;

        tempState = _inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool isPressed) && isPressed || tempState;

        if (tempState != lastButtonState) {
            Debug.Log("Primary Button Pressed");
            lastButtonState = tempState;
        }
    }
}
