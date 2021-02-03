using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButPlayer3 : MonoBehaviour
{

    public AudioSource SphereSound;
    private void OnMouseDown()
    {
        SphereSound.Play();
        SelectNowSphere.id = 3;
    }
}
