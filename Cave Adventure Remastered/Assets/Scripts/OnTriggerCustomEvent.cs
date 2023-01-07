using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerCustomEvent : MonoBehaviour
{
    [Header("Custom Event")] public UnityEvent myEventOnEnter;
    [Header("Custom Event")] public UnityEvent myEventOnExit;
    private void OnTriggerEnter(Collider other)
    {
        if (myEventOnEnter == null)
            print("myEvent == null");
        else
        {
            myEventOnEnter.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (myEventOnExit == null)
            print("myEvent == null");
        else
        {
            myEventOnExit.Invoke();
        }
    }
}
