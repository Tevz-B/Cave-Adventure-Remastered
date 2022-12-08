using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        // add player tag check
        if (openTrigger)
        {
            myDoor.Play("DoorOpen", 0, 0.0f);
            gameObject.SetActive(false);
        }
    }

}
