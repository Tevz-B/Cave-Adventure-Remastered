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

    public void ResetLevel()
    {
        coins = startCoins;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel()
    {
        startCoins = coins;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
