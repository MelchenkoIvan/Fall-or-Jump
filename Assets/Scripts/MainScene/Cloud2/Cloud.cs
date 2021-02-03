using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public GameObject cloud;
    
    void Start()
    {
        
            StartCoroutine(Spawn());
          
    }

    IEnumerator Spawn()
    {

        while (true)
        {
            
                Vector3 pos = Camera.main.ScreenToViewportPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
                Instantiate(cloud, pos, Quaternion.Euler(0, 180f, 0));               
               yield return new WaitForSeconds(5.01f);
            
                

        }


    }
   
}
