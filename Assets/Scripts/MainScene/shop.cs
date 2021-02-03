using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{

    public GameObject detectClicks, settings,allsphere;
    public GameObject NameGame, TapToplay,buy,select;

    void Update()
    {
        if (Player.lose == false)
        { 
            detectClicks.SetActive(false);
        settings.SetActive(false);
        allsphere.SetActive(true);
        NameGame.SetActive(false);
        TapToplay.SetActive(false);
        }

    }
    void OnDisable()
    {
        
        if(Player.lose ==false)
        {
             detectClicks.SetActive(true);
            settings.SetActive(true);
            allsphere.SetActive(false);
            NameGame.SetActive(true);
            TapToplay.SetActive(true);
            buy.SetActive(false);
            select.SetActive(false);
        }


    }
   
}
