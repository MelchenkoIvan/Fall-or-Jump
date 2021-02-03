using System.Collections;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject Platform,Money;
    private GameObject plarformInst;
    public float timeSpawn = 1.5f;

    private void Start()
    {
       
        StartCoroutine(Spawn());
    }
    private void Update()
    {
        if (upUp.countDestroyPlatform % 20 == 9)
        {

            timeSpawn = 0.8f;
        }
        else {
            timeSpawn = 1.7f;
        }     
        if (upUp.countDestroyPlatform > 45)
        {
            timeSpawn = 1.6f;
        }
        if (upUp.countDestroyPlatform > 70)
        {
            timeSpawn = 1.5f;
        }
        if (upUp.countDestroyPlatform > 100)
        {
            timeSpawn = 1.4f;
        }
    }

    IEnumerator Spawn()
    {
       

        while (!Player.lose)
        {
            plarformInst = Instantiate(Platform, new Vector3(Random.Range(-1.47f, 1.82f),-4f,-1.77f),Quaternion.identity);
            Platform.transform.localScale = new Vector3(Random.Range(0.18f, 0.3f), 0.26f, 0f);
            yield return new WaitForSeconds(timeSpawn);
            if (upUp.countDestroyPlatform % 2 == 0 && upUp.countDestroyPlatform != 0 && Player.lose == false)
            {
                GameObject MoneyInst = Instantiate(Money, new Vector3(plarformInst.transform.position.x, plarformInst.transform.position.y + 0.25f, plarformInst.transform.position.z), Quaternion.identity) as GameObject;
                MoneyInst.transform.parent = plarformInst.transform;
            }
            
            
             
        }
    
    }

  

}
