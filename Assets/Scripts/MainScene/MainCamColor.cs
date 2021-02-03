using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamColor : MonoBehaviour
{
    public Color blue1 = new Color(73, 168, 252);
    public Color blue2 = new Color(48, 157, 252);
    public Color blue3 = new Color(23, 141, 244);
    public Color blue4 = new Color(14, 122, 217);
    public Color blue5 = new Color(12, 110, 196);
    

    void Update()
    {
        if (upUp.countDestroyPlatform == 25 )
        {
            gameObject.GetComponent<Camera>().backgroundColor = blue1;

        }
        if (upUp.countDestroyPlatform == 50)
        {
            gameObject.GetComponent<Camera>().backgroundColor = blue2;

        }
        if (upUp.countDestroyPlatform == 75)
        {
            gameObject.GetComponent<Camera>().backgroundColor = blue2;

        }
        if (upUp.countDestroyPlatform == 100)
        {
            gameObject.GetComponent<Camera>().backgroundColor = blue2;

        }
        if (upUp.countDestroyPlatform == 125)
        {
            gameObject.GetComponent<Camera>().backgroundColor = blue2;

        }

    }
}
