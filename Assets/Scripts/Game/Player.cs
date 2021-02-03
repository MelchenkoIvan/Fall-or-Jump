using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject Restart;
    public GameObject particle;
    public AudioSource BoomBomb;
   

    private void Awake()
    {
        lose = false;
    }

    private void OnTriggerEnter2D(Collider2D finish)
    {
        if (finish.gameObject.tag == "Tria")
        {
            lose = true;

            BoomBomb.Play();
            

            Destroy(gameObject);
            Instantiate(particle, transform.position, transform.rotation);
            
            Restart.SetActive(true);
            
        }
    }
   
}
