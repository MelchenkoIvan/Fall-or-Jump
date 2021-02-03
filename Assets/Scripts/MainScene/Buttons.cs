using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public float big = 1f, small = 0.90f;
    public Sprite Sound_on, Sound_off;
    public GameObject shop;
    public AudioSource mouseClick;
    public AudioMixerGroup Mixer;

    void Update()
    {
        if (gameObject.name == "Settings")
        {

            if (PlayerPrefs.GetString("Sound") == "off")
            {
                transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Sound_off;
                Mixer.audioMixer.SetFloat("VolumeAll", -80);

            }
            else if (PlayerPrefs.GetString("Sound") == "on")
            {
               
                transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Sound_on;

               
            }
        }


    }

    void OnMouseDown()
    {
        transform.localScale = new Vector3(small, small, small);
    }
    void OnMouseUp()
    {
        transform.localScale = new Vector3(big, big, big);
        mouseClick.Play();

        switch (gameObject.name)
        {
          

            case "Settings":
                for (int i = 0; i < transform.childCount; i++)
                    transform.GetChild(i).gameObject.SetActive(!transform.GetChild(i).gameObject.activeSelf);
                break;
            case "Facebook":
                Application.OpenURL("https://facebook.com");
                break;
            case "Sound":
                if (PlayerPrefs.GetString("Sound") == "off")
                {
                    GetComponent<Image>().sprite = Sound_on;
                    
                    Mixer.audioMixer.SetFloat("VolumeAll",0);
                    PlayerPrefs.SetString("Sound", "on");
                }else
                { 
                    GetComponent<Image>().sprite = Sound_off;
                  
                    Mixer.audioMixer.SetFloat("VolumeAll", -80);
                    PlayerPrefs.SetString("Sound", "off");
                }
                break;


            case "Store":
                shop.SetActive(!shop.activeSelf);
                break;
        }

    }
    
}
