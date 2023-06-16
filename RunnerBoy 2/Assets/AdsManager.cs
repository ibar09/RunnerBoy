using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsManager : MonoBehaviour
{

    public void ShowInter()
    {
        Advertisements.Instance.ShowInterstitial();
    }
    public void ShowReward()
    {
        Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
        void CompleteMethod(bool completed, string advertiser)
        {
            Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
            if (completed == true)
            {
                //give the reward
            }
            else
            {
                //no reward
            }
        }

    }

}
