using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButPlay5 : MonoBehaviour
{
    public AudioSource SphereSound;


    private void OnMouseDown()
    {
        SphereSound.Play();
        SelectNowSphere.id = 5;
    }
}
