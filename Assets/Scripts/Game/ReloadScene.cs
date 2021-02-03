using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    

    void OnMouseDown()
    {
        transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    
        SceneManager.LoadScene("main");
      
    }
}
