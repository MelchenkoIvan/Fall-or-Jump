using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosePlace2 : MonoBehaviour
{
    public GameObject Restart, player;
    public GameObject particle;
    public AudioSource LoserPlace;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            LoserPlace.Play();
            Vector3 posPla = new Vector3(player.transform.position.x, player.transform.position.y-0.2f, player.transform.position.z);
            Player.lose = true;
            Destroy(gameObject);
            Destroy(player);
            Instantiate(particle, posPla, transform.rotation);

            Restart.SetActive(true);
        }
    }
}
