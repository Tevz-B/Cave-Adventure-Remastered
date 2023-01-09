using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] AudioClip coinSound;
    AudioSource audioSource;
    private void Start()
    {
        gameObject.SetActive(true); // set active at start
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            audioSource = Camera.main.GetComponent<AudioSource>();

            FindObjectOfType<GameSession>().PickupCoin();

            audioSource.PlayOneShot(coinSound, 1);
            Destroy(gameObject);
        }
    }
}
