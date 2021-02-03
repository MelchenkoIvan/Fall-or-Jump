using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upUp : MonoBehaviour
{
    private float Upspeed = 1.5f;
    public static int countDestroyPlatform = 0;
    public static int countPlatform = 0;
    void Update()
    {
        if (transform.position.y > 4f || Player.lose == true)
        {
            countDestroyPlatform++;
            Destroy(gameObject);
        }

        if (upUp.countDestroyPlatform > 20)
        {
            Upspeed = 1.7f;
        }
        if (upUp.countDestroyPlatform > 45)
        {
            Upspeed = 1.9f;
        }
        if (upUp.countDestroyPlatform > 70)
        {
            Upspeed = 2f;
        }
        if (upUp.countDestroyPlatform > 100)
        {
            Upspeed = 2.1f;
        }
        transform.position += new Vector3(0, Upspeed * Time.deltaTime, 0);
        countPlatform++;
    }
}
