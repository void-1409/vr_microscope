using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemScript : MonoBehaviour
{
    [SerializeField] private InputActionProperty triggerButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float isPressed = triggerButton.action.ReadValue<float>();
        
        // Debug.Log(isPressed);
    }
}
