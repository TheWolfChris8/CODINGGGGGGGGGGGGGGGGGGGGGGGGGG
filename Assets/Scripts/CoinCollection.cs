using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            score ++;
            UpdateScore();
            Destroy(other.gameObject);
        }
    }

    private void UpdateScore()
    {
        scoreText.text = "Coins Collected: " + score;
    }
}
