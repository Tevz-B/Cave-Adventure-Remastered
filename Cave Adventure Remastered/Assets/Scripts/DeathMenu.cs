using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathMenu : MonoBehaviour
{
    public void Continue()
    {
        FindObjectOfType<GameSession>().ResetLevel();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
