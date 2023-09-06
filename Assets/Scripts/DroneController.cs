using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DroneController : MonoBehaviour
{
    public Rigidbody drone;
    public float flySpeed = 5f;

    private XRGrabInteractable grabbable;
    // Start is called before the first frame update
    void Start()
    {
        grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(flyUp);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void flyUp(ActivateEventArgs arg)
    {
        Debug.Log(grabbable.activated);
        Debug.Log("Flying up!");
    }
}
