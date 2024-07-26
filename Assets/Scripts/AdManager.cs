using TapsellPlusSDK;
using TapsellPlusSDK.models;
using UnityEngine;
using TMPro;

public class AdManager : MonoBehaviour
{
    private const string ZoneID = "669d0ea19243274b7be5742f";
    private static string _responseId;
    [SerializeField] private TextMeshProUGUI loadStatus;
    [SerializeField] private TextMeshProUGUI adStatus;

    void Start()
    {
        Display();
    }
    public void Request()
    {
        loadStatus.text = "(Loading Ad...)";
        TapsellPlus.RequestStandardBannerAd(ZoneID, BannerType.Banner320X50,
            tapsellPlusAdModel =>
            {
                Debug.Log("on response " + tapsellPlusAdModel.responseId);
                loadStatus.text = "";
                adStatus.text = "•";
                _responseId = tapsellPlusAdModel.responseId;
            },
            error => { 
                loadStatus.text = "";
                Debug.Log("Error " + error.message); 
                }
        );
    }

    public void Show()
    {
        TapsellPlus.ShowStandardBannerAd(_responseId, Gravity.Bottom, Gravity.Center,
            tapsellPlusAdModel => {
                 adStatus.text = "";
                 Debug.Log("onOpenAd " + tapsellPlusAdModel.zoneId); 
                 },
            error => { Debug.Log("onError " + error.errorMessage); }
        );
    }

    public void Hide()
    {
        TapsellPlus.HideStandardBannerAd();
    }

    public void Display()
    {
        TapsellPlus.DisplayStandardBannerAd();
    }

    public void Destroy()
    {
        TapsellPlus.DestroyStandardBannerAd(_responseId);
    }
}