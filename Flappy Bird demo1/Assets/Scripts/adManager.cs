using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class adManager : MonoBehaviour
{
    string gameID = "4800848";
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID);
        ShowBanner();
        Invoke("HideBanner", 3f);
    }
    public void ShowBanner()
    {
        if (Advertisement.IsReady("Banner_Android")) 
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show("Banner_Android");
        }
        else
        {
            StartCoroutine(TryShowBanner());
        }
    }

    private IEnumerator TryShowBanner()
    {
        yield return new WaitForSeconds(1);
        ShowBanner();
    }
    public void HideBanner()
    {
        Advertisement.Banner.Hide();
    }
    private void update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            HideBanner();
        }
    }
    public void ShowInterstitital()
    {
        if (Advertisement.IsReady("Interstitial_Android"))
        {
            Advertisement.Show("Interstitial_Android");
        }

    }
}
