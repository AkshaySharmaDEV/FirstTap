using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;


public class UnityAds : MonoBehaviour, IUnityAdsListener
{
    public TMP_Text TextVisible;
    public GameObject Text;
    public Button Shoe;
    private string gameID = "4094407";
    private string bannerID = "Banner";
    private string interstitialID = "Interstitial";
    private string rewardedVideoID = "rewardedVideo";
    public bool TestMode;
    
    

    void Start()
    {
        Advertisement.Initialize(gameID, TestMode);
        // showInterstitial.interactable = Advertisement.IsReady(interstitialID);
        
        Advertisement.AddListener(this);
    }

    public void ShowInterstitial()
    {
        if (Advertisement.IsReady(interstitialID))
        {
            Advertisement.Show(interstitialID);
        }
    }

    public void ShowRewardedVideo()
    {
        Advertisement.Show(rewardedVideoID);
    }

    public void HideBanner()
    {
        Advertisement.Banner.Hide();
    }

    public void OnUnityAdsReady(string placementID)
    {
        if (placementID == rewardedVideoID)
        {
            
        }

        if (placementID == interstitialID)
        {
            // showInterstitial.interactable = true;
        }

        if (placementID == bannerID)
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_LEFT);
            Advertisement.Banner.Show(bannerID);
        }
    }

    public void OnUnityAdsDidFinish(string placementID, ShowResult showResult)
    {
        if (placementID == rewardedVideoID)
        {
            if (showResult == ShowResult.Finished)
            {
                GetReward();
            }
            else if (showResult == ShowResult.Skipped)
            {
                //Do nothing
            }
            else if (showResult == ShowResult.Failed)
            {
                //tell player ads failed
            }
        }
    }


    public void OnUnityAdsDidError(string message)
    {
        //Show or log the error here
    }

    public void OnUnityAdsDidStart(string placementID)
    {
        //Do this if ads starts
    }

    public void GetReward()
    {
        

            
        TextVisible.text = ("Shoe Unlocked!");
        Text.SetActive(true);
        StartCoroutine(ExampleCoroutine());
        Shoe.interactable = true;

        
    }


    IEnumerator ExampleCoroutine()
    {
        

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        Text.SetActive(false);

        
    }

    public void UnlockDress()
    {


    }
}
