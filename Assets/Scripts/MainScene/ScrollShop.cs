using UnityEngine;

public class ScrollShop : MonoBehaviour
{
    public GameObject sphere;
    private Vector3 screenPoint, offset;
    private float lockedXpos ;

    void Update()
    {
        if (sphere.transform.position.y > 1.3)
        {
            sphere.transform.position = Vector3.MoveTowards(sphere.transform.position, new Vector3(sphere.transform.position.x, 0f, sphere.transform.position.z), Time.deltaTime * 10f);
        }
        else if (sphere.transform.position.y < -1)
        {
            sphere.transform.position = Vector3.MoveTowards(sphere.transform.position, new Vector3(sphere.transform.position.x, -0.7f, sphere.transform.position.z), Time.deltaTime * 10f);
        }
    }
    void OnMouseDown()
    {
        lockedXpos = screenPoint.y;
        offset = sphere.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.x = lockedXpos;
        sphere.transform.position = curPosition;
    }
    
}
