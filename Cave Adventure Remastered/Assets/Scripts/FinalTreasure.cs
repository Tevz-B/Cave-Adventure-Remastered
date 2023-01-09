using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTreasure : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameSession>().WinGame();
        }
    }
}
