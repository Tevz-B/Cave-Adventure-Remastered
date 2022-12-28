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
            // increase counter
            //StarterAssets.Player player;
            //player = other.GetComponentInParent<StarterAssets.Player>();

            //if (player)
            //{
            //    player.PickupCoin();
            //    Debug.Log(player.Coins());
            //    Destroy(gameObject);
            //}
            //FindObjectOfType<GameSession>().PickupCoin();
            //GetComponent<AudioSource>().Play();
            //GetComponent<MeshRenderer>().gameObject.SetActive(false);
            //GetComponent<Collider>().gameObject.SetActive(false);
            //Destroy(gameObject, 3);

            audioSource = Camera.main.GetComponent<AudioSource>();

            FindObjectOfType<GameSession>().PickupCoin();

            audioSource.PlayOneShot(coinSound, 1);
            Destroy(gameObject);
        }
    }
}
