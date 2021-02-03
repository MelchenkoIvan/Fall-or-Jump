using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectNowSphere : MonoBehaviour

{
    public static int id;
    public GameObject Sphere1, Sphere2, Sphere3, Sphere4, Sphere5, mainSphere;
    public AudioSource SeleCtMusic;

   

    void OnMouseDown()
    {
        transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        SeleCtMusic.Play();
    }
    void OnMouseUp()
    {
        
        transform.localScale = new Vector3(1f, 1f, 1f);

        if (id == 1 && PlayerPrefs.GetString(Sphere1.gameObject.name) == "Open") 
        {
            mainSphere.GetComponent<MeshRenderer>().material = Sphere1.GetComponent<MeshRenderer>().material;           
        }
        else if ( id == 2 && PlayerPrefs.GetString(Sphere2.gameObject.name) == "Open")
        {
            mainSphere.GetComponent<MeshRenderer>().material = Sphere2.GetComponent<MeshRenderer>().material;       
        }
        else if (id == 3 && PlayerPrefs.GetString(Sphere3.gameObject.name) == "Open")
        {
            mainSphere.GetComponent<MeshRenderer>().material = Sphere3.GetComponent<MeshRenderer>().material;         
        }
        else if (id == 4 && PlayerPrefs.GetString(Sphere4.gameObject.name) == "Open")
        {
            mainSphere.GetComponent<MeshRenderer>().material = Sphere4.GetComponent<MeshRenderer>().material;
        }
        else if ( id == 5 && PlayerPrefs.GetString(Sphere5.gameObject.name) == "Open")
        {
            mainSphere.GetComponent<MeshRenderer>().material = Sphere5.GetComponent<MeshRenderer>().material;
        }
    }
}
