using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    public static GameSession Instance;
    public int coins = 0;
    public int startCoins = 0;
    public int currentLevelIndex = 1;

    [SerializeField] TextMeshProUGUI CoinsText;
    [SerializeField] TextMeshProUGUI InteractText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        CoinsText.text = coins.ToString();
        InteractText.gameObject.SetActive(false);
        currentLevelIndex = clamp(SceneManager.GetActiveScene().buildIndex, 1, 2);
        
    }

    public int clamp(int num, int min, int max)
    {
        if (num < min)
        {
            return min;
        }
        else if (num > max)
        {
            return max;
        }
        else
        {
            return num;
        }
    }

    public void PickupCoin()
    {
        coins++;
        CoinsText.text = coins.ToString();
    }
    public int Coins()
    {
        return coins;
    }

    public void ShowInteractText()
    {
        InteractText.gameObject.SetActive(true);
    }

    public void HideInteractText()
    {
        InteractText.gameObject.SetActive(false);
    }

    public void Death()
    {
        SceneManager.LoadScene("DeathScreen");
    }

    public void ResetLevel()
    {
        coins = startCoins;
        CoinsText.text = coins.ToString();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(currentLevelIndex);
    }

    public void NextLevel()
    {
        startCoins = coins;
        currentLevelIndex = clamp(currentLevelIndex + 1, 1, 2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void WinGame()
    {
        SceneManager.LoadScene("EndScreen");
    }
}
