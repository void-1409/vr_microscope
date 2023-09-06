using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeLocomotion : MonoBehaviour
{
    [SerializeField] private LocomotionSystem player;
    [SerializeField] private GameObject drone;

    public void changeByMenu(int index){
        if (index == 0){
            player.enabled = true;
            drone.SetActive(false);
        }
        else if (index == 1){
            player.enabled = false;
            drone.SetActive(true);
        }
    }
}
