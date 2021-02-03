using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTriangle : MonoBehaviour
{
    public GameObject Platform;
    public static int countTriangle;
    public float timeSpawn = 2f;

    private void Start()
    {
    
        StartCoroutine(Spawn());
    }
    private void Update()
    {
       
        if (Player.lose == true)
            countTriangle = 0;
        if (upUp.countDestroyPlatform % 20 == 10)
        {

            timeSpawn = 0.5f;
        }
        else {
            if (upUp.countDestroyPlatform > 10)
            {
                timeSpawn = 1.8f;
            }
            if (upUp.countDestroyPlatform > 18)
            {
                timeSpawn = 1.5f;
            }
            if (upUp.countDestroyPlatform > 30)
            {
                timeSpawn = 1.3f;
            }
            if (upUp.countDestroyPlatform > 70)
            {
                timeSpawn = 1.2f;
            }
            if (upUp.countDestroyPlatform > 85)
            {
                timeSpawn = 1.1f;
            }
            if (upUp.countDestroyPlatform > 100)
            {
                timeSpawn = 1f;
            }
            if (upUp.countDestroyPlatform > 130)
            {
                timeSpawn = 0.9f;
            }
            if (upUp.countDestroyPlatform > 170)
            {
                timeSpawn = 0.7f;
            }

        }
        
       
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            countTriangle++;
            Instantiate(Platform, new Vector3(Random.Range(-1.72f, 1.83f), 3.54f, 0f), Quaternion.identity);
            //Platform.transform.localScale = new Vector3(Random.Range(0.18f, 0.3f), 0.26f, 0f);
            yield return new WaitForSeconds(timeSpawn);

        }

    }
  
}
