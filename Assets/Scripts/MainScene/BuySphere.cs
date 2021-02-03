using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySphere : MonoBehaviour
{
    public GameObject selectBtn;
    public GameObject Sphere1,  Sphere2, Sphere3, Sphere4, Sphere5,mainSphere;
    public AudioSource BuySound;

    void OnMouseDown()
    {
        transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
    }

    void OnMouseUp()
    {

        BuySound.Play();
        transform.localScale = new Vector3(1f, 1f, 1f);

        if (PlayerPrefs.GetInt("Coins") >= 40 && SelectNowSphere.id == 1)
        {

            PlayerPrefs.SetString(Sphere1.GetComponent<SelectSphere>().nowSphere, "Open");
           
                mainSphere.GetComponent<MeshRenderer>().material = Sphere1.GetComponent<MeshRenderer>().material;
              
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 40);
                selectBtn.SetActive(true);
                gameObject.SetActive(false);
           

        }
        else if (PlayerPrefs.GetInt("Coins") >= 150 && SelectNowSphere.id == 2)
        {
           
            PlayerPrefs.SetString(Sphere2.GetComponent<SelectSphere>().nowSphere, "Open");
            mainSphere.GetComponent<MeshRenderer>().material = Sphere2.GetComponent<MeshRenderer>().material;
          
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 150);
            selectBtn.SetActive(true);
            gameObject.SetActive(false);
           

        }
        else if (PlayerPrefs.GetInt("Coins") >= 150 && SelectNowSphere.id == 3)
        {
          
            PlayerPrefs.SetString(Sphere3.GetComponent<SelectSphere>().nowSphere, "Open");
            mainSphere.GetComponent<MeshRenderer>().material = Sphere3.GetComponent<MeshRenderer>().material;
            
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 150);
            selectBtn.SetActive(true);
            gameObject.SetActive(false);
          

        }
        else if (PlayerPrefs.GetInt("Coins") >= 150 && SelectNowSphere.id == 4)
        {
            
           PlayerPrefs.SetString(Sphere4.GetComponent<SelectSphere>().nowSphere, "Open");
            mainSphere.GetComponent<MeshRenderer>().material = Sphere4.GetComponent<MeshRenderer>().material;
            
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 150);
            selectBtn.SetActive(true);
            gameObject.SetActive(false);
        

        }
        else if (PlayerPrefs.GetInt("Coins") >= 150 && SelectNowSphere.id == 5)
        {
          
            PlayerPrefs.SetString(Sphere5.GetComponent<SelectSphere>().nowSphere, "Open");
            mainSphere.GetComponent<MeshRenderer>().material = Sphere5.GetComponent<MeshRenderer>().material;
           // PlayerPrefs.SetString("Now", Sphere5.GetComponent<SelectSphere>().nowSphere);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 150);
            selectBtn.SetActive(true);
            gameObject.SetActive(false);
         

        }
    }
}
