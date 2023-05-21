using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    public GameObject adstidakada;
    string gameId = "4698301";
    public GameObject loading;

    private void Awake()
    {
        InitializeAds();
    }

    public void InitializeAds()
    {
        Advertisement.Initialize(gameId, false, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("initialize Completed");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        throw new System.NotImplementedException();
    }

    //---------------------------------------------------------------------------------

    public void LoadAd()
    {

        loading.gameObject.SetActive(true);
        Advertisement.Load("Rewarded_Android", this);
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Advertisement.Show(placementId, this);
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        loading.gameObject.SetActive(false);
        Debug.Log($"Error loading Ad Unit {gameId}: {error.ToString()} - {message}");
        adstidakada.gameObject.SetActive(true);
    }

    //---------------------------------------------------------------------------------

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        loading.gameObject.SetActive(false);
        Debug.Log($"Error showing Ad Unit {gameId}: {error.ToString()} - {message}");
        adstidakada.gameObject.SetActive(true);
    }

    public void OnUnityAdsShowStart(string placementId){}

    public void OnUnityAdsShowClick(string placementId){}

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        loading.gameObject.SetActive(false);
        tickets.tiket += 1;
        SaveSystem.SaveDataMoney();
    }
}
