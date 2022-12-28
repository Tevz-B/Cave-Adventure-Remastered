using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    //[SerializeField] private bool closeTrigger = false;

    private StarterAssets.StarterAssetsInputs _input;

    private void Start()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        // add player tag check
        if (openTrigger)
        {
            if ( _input && _input.press)
            {
                myDoor.Play("DoorOpen", 0, 0.0f);
                gameObject.SetActive(false);
                FindObjectOfType<GameSession>().HideInteractText();
                GameObject.Destroy(this);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        _input = other.GetComponentInParent<StarterAssets.StarterAssetsInputs>();
        FindObjectOfType<GameSession>().ShowInteractText();
    }

    private void OnTriggerExit(Collider other)
    {
        _input = null;
        FindObjectOfType<GameSession>().HideInteractText();

    }


}