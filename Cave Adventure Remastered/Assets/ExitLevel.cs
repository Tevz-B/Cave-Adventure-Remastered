using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
           // SceneManager.LoadScene(currentSceneIndex + 1);
        }

    }
}
