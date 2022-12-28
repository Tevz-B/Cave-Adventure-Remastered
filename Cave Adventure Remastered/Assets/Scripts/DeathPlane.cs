using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeathPlane : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameSession>().ResetLevel();
        }
    }
}
