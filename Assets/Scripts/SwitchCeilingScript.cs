using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SwitchCeilingScript : MonoBehaviour
{
    [SerializeField] private GameObject ceilingLight;

    private bool isLightOn = false;

    void Start()
    {
        ceilingLight.SetActive(isLightOn);
    }

    void Update()
    {
    }

    public void changeLightState() {
        isLightOn = !isLightOn;
        ceilingLight.SetActive(isLightOn);
        Debug.Log("Light State Changed!");
        Debug.Log(isLightOn);
    }
}
