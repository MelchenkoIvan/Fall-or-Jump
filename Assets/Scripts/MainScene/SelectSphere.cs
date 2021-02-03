using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSphere : MonoBehaviour
{
    [HideInInspector]
    public string nowSphere;
    public GameObject selectSphere, Buysphere, mainSphere;

    void Start()
    {
        if (PlayerPrefs.GetString("Player1") != "Open") 
        {
            PlayerPrefs.SetString("Player1", "Open");
            PlayerPrefs.GetString("Now");
          

        }
       

    }

    void OnMouseDown()
    {
        transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
    }

    void OnMouseUp()
    {
     
        nowSphere = gameObject.name;
        transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        if (PlayerPrefs.GetString(gameObject.name) == "Open")
        {
            selectSphere.SetActive(true);
            Buysphere.SetActive(false);
        }
        else
        {
            selectSphere.SetActive(false);
            Buysphere.SetActive(true);

        }

    }
}
