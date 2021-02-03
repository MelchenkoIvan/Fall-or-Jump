using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject pdlayer;
    private float speed = 2.5f;

    void Update()
    {
        if (upUp.countDestroyPlatform > 35) 
        {
            speed = 2.7f;
        }
        if (upUp.countDestroyPlatform > 70)
        {
            speed = 2.9f;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 12;
        }
        if (upUp.countDestroyPlatform > 100)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 14;
            speed = 3.1f;
        }


    }




    void OnMouseDrag()
    {
     
        if (Player.lose == false)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x < -1.72f ? -1.72f : mousePos.x;
            mousePos.x = mousePos.x > 1.72f ? 1.72f : mousePos.x;
            pdlayer.transform.position = Vector2.MoveTowards(pdlayer.transform.position, new Vector2(mousePos.x, pdlayer.transform.position.y), speed * Time.deltaTime);

        }

    }
}
