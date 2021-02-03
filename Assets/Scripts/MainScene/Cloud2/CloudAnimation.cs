using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CloudAnimation : MonoBehaviour
{

    private SpriteRenderer Cloud;
    private float Speed = 0.1f;
    void Start()
    {
      
            Cloud = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 5f);

    }
    void Update()
    {
        
            Cloud.color = new Color(Cloud.color.r, Cloud.color.g, Cloud.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));
        transform.position += transform.right * Time.deltaTime * Speed;

    }

}
