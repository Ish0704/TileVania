using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip audioclip;
    [SerializeField] int pointsOfCoins = 100;
    bool wasCollected = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !wasCollected)
        {
            wasCollected = true;
            FindObjectOfType<GameSession>().AddScore(pointsOfCoins);
            AudioSource.PlayClipAtPoint(audioclip,Camera.main.transform.position);
            gameObject.SetActive(false);
            Destroy(gameObject);
            
        }

    }
}
