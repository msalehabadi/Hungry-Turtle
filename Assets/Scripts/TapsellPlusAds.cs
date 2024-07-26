using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TapsellPlusSDK;
using System;

public class TapsellPlusAds : MonoBehaviour
{
    public string AppKey = "gtknblstkhgaeifobjrghbcjqjgjljkjmbogqkscldqcdnsigcentnlnoqljcqhbboocdp";
    void Start()
    {
        TapsellPlus.Initialize(AppKey,
            adNetworkName => Debug.Log(adNetworkName + " Initialized Successfully."),
            error => Debug.Log(error.ToString()));
    }


}
