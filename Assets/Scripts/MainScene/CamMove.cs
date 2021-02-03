using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject playerSph;

    private void Update()
    {
        transform.position = new Vector3(playerSph.transform.position.x, playerSph.transform.position.y, -1.5f);
    }
}
