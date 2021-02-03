using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButPlayer1 : MonoBehaviour
{
    public AudioSource SphereSound;
        

    void OnMouseDown()
    {
        SphereSound.Play();
        SelectNowSphere.id = 1;
    }
}
