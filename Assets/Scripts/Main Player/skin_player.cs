using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skin_player : MonoBehaviour
{
    public GameObject[] playerSkin;


    public void saveDataSkinPlayer()
    {
        SaveSystem.SaveDataSkin(this);
    }

    void allOffSkin()
    {
        for(int i = 0; i < playerSkin.Length; i++)
        {
            playerSkin[i].gameObject.SetActive(false);
        }
    }

    public void allOffPatokan()
    {
        allOffSkin();
    }


    private void Update()
    {
        usingSkinMechanic();
    }


    void usingSkinMechanic()
    {
        switch (skin.patokan_digunakan)
        {
            case 0:
                playerSkin[0].gameObject.SetActive(true);
                break;
            case 1:
                playerSkin[1].gameObject.SetActive(true);
                break;
            case 2:
                playerSkin[2].gameObject.SetActive(true);
                break;
            case 3:
                playerSkin[3].gameObject.SetActive(true);
                break;
            case 4:
                playerSkin[4].gameObject.SetActive(true);
                break;
            case 5:
                playerSkin[5].gameObject.SetActive(true);
                break;
        }
    }

    public void DefaultSkin()
    {
        allOffPatokan();
    }
    public void TriangleSkin()
    {
        allOffPatokan();
    }
    public void SixSideSkin()
    {
        allOffPatokan();
    }
    public void CeperSkin()
    {
        allOffPatokan();
    }
    public void CapsuleSkin()
    {
        allOffPatokan();
    }
    public void O_Skin()
    {
        allOffPatokan();
    }
}
