using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButPlay2 : MonoBehaviour
{
    public AudioSource SphereSound;

    private void OnMouseDown()
    {
        SphereSound.Play();
        SelectNowSphere.id = 2;
    }
}
