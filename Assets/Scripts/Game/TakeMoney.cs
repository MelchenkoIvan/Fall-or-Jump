using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeMoney : MonoBehaviour
{
    public Text Money;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Coin") 
        {
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt(("Coins") ,  PlayerPrefs.GetInt("Coins") + 1);
            Money.text = ": " + PlayerPrefs.GetInt("Coins").ToString();
            
           
        }
    }
}
