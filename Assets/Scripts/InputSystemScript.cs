using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemScript : MonoBehaviour
{
    [SerializeField] private InputActionProperty button1;
    [SerializeField] private InputActionProperty button2;
    [SerializeField] private InputActionProperty button3;
    [SerializeField] private InputActionProperty button4;
    [SerializeField] private InputActionProperty joystick_left;
    [SerializeField] private InputActionProperty joystick_right;

    private Vector2 zerovector = new Vector2(0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pressed1 = button1.action.ReadValue<float>();
        if (pressed1 > 0){
            Debug.Log("Button 1 pressed!");
        }
        float pressed2 = button2.action.ReadValue<float>();
        if (pressed2 > 0){
            Debug.Log("Button 2 pressed!");
        }
        float pressed3 = button3.action.ReadValue<float>();
        if (pressed3 > 0){
            Debug.Log("Button 3 pressed!");
        }
        float pressed4 = button4.action.ReadValue<float>();
        if (pressed4 > 0){
            Debug.Log("Button 4 pressed!");
        }

        Vector2 joyleft = joystick_left.action.ReadValue<Vector2>();
        if (joyleft != zerovector){
            Debug.Log(joyleft);
        }
        Vector2 joyright = joystick_right.action.ReadValue<Vector2>();
        if (joyright != zerovector){
            Debug.Log(joyright);
        }
        // Debug.Log(isPressed);
    }
}
