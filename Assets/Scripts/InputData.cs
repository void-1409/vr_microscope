using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class InputData : MonoBehaviour {
    public InputDevice _rightController;
    public InputDevice _leftController;
    public InputDevice _HMD;


    void Start() {
        if (!_rightController.isValid || !_leftController.isValid || !_HMD.isValid) {
            InitializeDevices();
        }
    }

    private void InitializeDevices() {
        if (!_rightController.isValid)
            InitializeInputDevice(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Right, ref _rightController);
        if (!_leftController.isValid)
            InitializeInputDevice(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Left, ref _leftController);
        if (!_HMD.isValid)
            InitializeInputDevice(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.HeadMounted, ref _HMD);
    }

    private void InitializeInputDevice(InputDeviceCharacteristics inputCharacterstics, ref InputDevice inputDevice) {
        List<InputDevice> devices = new List<InputDevice>();

        InputDevices.GetDevicesWithCharacteristics(inputCharacterstics, devices);

        if (devices.Count > 0) {
            inputDevice = devices[0];
        }
    }

    void Update() {

    }
}
