using UnityEngine.UI;
using UnityEngine;

public class countMoney : MonoBehaviour
{
    private Text txt;
  

    void Update()
    {
        txt = GetComponent<Text>();
        txt.text = PlayerPrefs.GetInt("Coins").ToString();
       
           

    }

    
}
