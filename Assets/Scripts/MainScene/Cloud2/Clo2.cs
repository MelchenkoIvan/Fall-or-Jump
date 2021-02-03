using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clo2 : MonoBehaviour
{
    public GameObject cloud2;
    void Start()
    {
        StartCoroutine(Spawn2());
    }

    IEnumerator Spawn2()
    {
        while (true)
        {
           
                Vector3 pos = Camera.main.ScreenToViewportPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
                Instantiate(cloud2, pos, Quaternion.Euler(0, 0, 0));
                yield return new WaitForSeconds(5.01f);
            
        }
    }
}
