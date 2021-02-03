using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsVideo : MonoBehaviour
{
    private string gameId = "3765999", placementId = "video";
    private bool testmode = true;
    private static int counLose;
    private Coroutine showAd;

    private void Start()
    {
        Advertisement.Initialize(gameId, testmode);

        counLose++;
        if (counLose % 4 == 0)
            showAd = StartCoroutine(ShowAd());
    }


    IEnumerator ShowAd()
    {
        while (true)
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show(placementId);
                break;
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
