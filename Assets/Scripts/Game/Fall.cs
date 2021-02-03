using UnityEngine;

public class Fall : MonoBehaviour
{
    private float fallspeed = 0.2f;
    
    void Update()
    {
        
        if (transform.position.y < -4f || Player.lose == true)
        {
            Destroy(gameObject);
        }
        if (SpawnTriangle.countTriangle > 4)
        {
            fallspeed = 1.5f;
        }
        if (upUp.countDestroyPlatform > 20)
        {
            fallspeed = 1.6f;
        }
        if (upUp.countDestroyPlatform > 45)
        {
            fallspeed = 1.7f;
        }
        if (upUp.countDestroyPlatform > 70)
        {
            fallspeed = 1.9f;
        }
        if (upUp.countDestroyPlatform > 100)
        {
            fallspeed = 2f;
        }
        if (upUp.countDestroyPlatform > 180)
        {
            fallspeed = 2.1f;
        }

        if (Player.lose == true)
            SpawnTriangle.countTriangle = 0;

        transform.position -= new Vector3(0, fallspeed * Time.deltaTime, 0);
    }
}
