using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TapPlay : MonoBehaviour
{

    private RectTransform rec;

    public Text playText, gameName;
    public GameObject Buttons, player , Spawn_platform, ButtonJump, LoserPlace, LoserPlaceTwo , StudyText, record;
    public GameObject AdsMana;
    public GameObject Sphere1, Sphere2, Sphere3, Sphere4, Sphere5, mainSphere;



    private void Start()
    {
        //PlayerPrefs.SetInt("Coins", 9999999);
        //rec = GetComponent<RectTransform>(); 

    }
    private void Update()
    {
        if(Player.lose == false)
        player.gameObject.GetComponent<Rigidbody2D>().velocity -= player.gameObject.GetComponent<Rigidbody2D>().velocity;
        if (SelectNowSphere.id == 1 && PlayerPrefs.GetString(Sphere1.gameObject.name) == "Open")
        {
            mainSphere.GetComponent<MeshRenderer>().material = Sphere1.GetComponent<MeshRenderer>().material;

        }
        else if (SelectNowSphere.id == 2 && PlayerPrefs.GetString(Sphere2.gameObject.name) == "Open")
        {

            mainSphere.GetComponent<MeshRenderer>().material = Sphere2.GetComponent<MeshRenderer>().material;


        }
        else if (SelectNowSphere.id == 3 && PlayerPrefs.GetString(Sphere3.gameObject.name) == "Open")
        {
            mainSphere.GetComponent<MeshRenderer>().material = Sphere3.GetComponent<MeshRenderer>().material;

        }
        else if (SelectNowSphere.id == 4 && PlayerPrefs.GetString(Sphere4.gameObject.name) == "Open")
        {


            mainSphere.GetComponent<MeshRenderer>().material = Sphere4.GetComponent<MeshRenderer>().material;



        }
        else if (SelectNowSphere.id == 5 && PlayerPrefs.GetString(Sphere5.gameObject.name) == "Open")
        {

            mainSphere.GetComponent<MeshRenderer>().material = Sphere5.GetComponent<MeshRenderer>().material;


        }
    }

    private bool clicked;

    private void OnMouseDown()
    {
        if (!clicked)
        {
            clicked = true;
            Spawn_platform.GetComponent<SpawnPlatform>().enabled = true;
            Spawn_platform.GetComponent<SpawnTriangle>().enabled = true;
            ButtonJump.SetActive(true);
            LoserPlace.SetActive(true);
            StudyText.gameObject.SetActive(true);
            record.SetActive(true);
            LoserPlaceTwo.SetActive(true);
            playText.gameObject.SetActive(false);
            //AdsMana.GetComponent<Ads>().enabled = false;
            gameName.text = "0";
            

            Buttons.gameObject.transform.position = new Vector3(0f, -4f, 0f);
            player.GetComponent<Animation>().Play("StartClip");


        }
        else if (clicked && StudyText.gameObject.activeSelf )
        {
            StudyText.gameObject.SetActive(false);
          
        }
        
       
    }
  
}
