using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text record;
    private Text txt;
    private bool gameStart;
    void Start()
    {
        record.text = "Best Record : " + PlayerPrefs.GetInt("record").ToString();
        txt = GetComponent<Text>();
        upUp.countDestroyPlatform = 0;
    }

   
    void Update()
    {
        if (txt.text == "0")
            gameStart = true;
        if (gameStart)
            txt.text = upUp.countDestroyPlatform.ToString();
        if (PlayerPrefs.GetInt("record") < upUp.countDestroyPlatform)
            PlayerPrefs.SetInt("record", upUp.countDestroyPlatform);
        record.text = "Best Record : " + PlayerPrefs.GetInt("record").ToString();
    }
}
