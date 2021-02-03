using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloAn2 : MonoBehaviour
{
    private SpriteRenderer Cloud2;
    private float Speed = 0.1f;
    void Start()
    {
      
            Cloud2 = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 5f);

    }
    void Update()
    {
      
            Cloud2.color = new Color(Cloud2.color.r, Cloud2.color.g, Cloud2.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));
        transform.position += transform.right * Time.deltaTime * Speed;

    }
}
