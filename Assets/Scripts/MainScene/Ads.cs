using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
    private string gameId = "3765999", placementId = "Banner";
    private bool testmode = true;
    private static int counLose ;
    private Coroutine showAd;

    IEnumerator Start()
    {
        Advertisement.Initialize(gameId, testmode);
        while (!Advertisement.IsReady(placementId))
            yield return null;
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(placementId);

        //counLose++;
        //if (counLose % 3 == 0)
        //    showAd = StartCoroutine(ShowAd());
    }


    //IEnumerator ShowAd()
    //{
    //    while (true)
    //    {
    //        if (Advertisement.IsReady())
    //        {
    //            Advertisement.Show(type);
    //            break;
    //        }
    //        yield return new WaitForSeconds(1f);
    //    }
    //}
}
