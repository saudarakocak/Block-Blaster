using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject[] beli;
    public GameObject[] telahbeli;

    [Header("object extends")]
    public GameObject[] lockPanel;


    public int[] harga;

    [Header("Beli Indicator")]
    public bool triangle_shop;
    public bool sixSide_shop;
    public bool ceper_shop;
    public bool capsule_shop;
    public bool O_shop;

    public static bool _triangle_shop;
    public static bool _sixSide_shop;
    public static bool _ceper_shop;
    public static bool _capsule_shop;
    public static bool _O_shop;

    [Header("UI tambahan")]
    public GameObject tidakCukupUang;

    public void saveDataShopHistory()
    {
        SaveSystem.SaveDataShop(this);
    }

    private void Start()
    {
        //get data
        triangle_shop = _triangle_shop;
        sixSide_shop = _sixSide_shop;
        ceper_shop = _ceper_shop;
        capsule_shop = _capsule_shop;
        O_shop = _O_shop;
    }

    private void Update()
    {
        checkShopCondition();
    }

    public void membeli(int target)
    {
        if (money_player.money >= harga[target])
        {
            FindObjectOfType<AudioManager>().Play("Buy");
            targetChosen(target);
            money_player.money -= harga[target];
            SaveSystem.SaveDataMoney();
        }else
        {
            //tampilkan tidak cukup duit bos
            tidakCukupUang.gameObject.SetActive(true);
        }
    }

    void targetChosen(int x)
    {
        switch (x)
        {
            case 0:
                triangle_shop = true;
                break;
            case 1:
                sixSide_shop = true;
                break;
            case 2:
                ceper_shop = true;
                break;
            case 3:
                capsule_shop = true;
                break;
            case 4:
                O_shop = true;
                break;
        }
    }

    void checkShopCondition()
    {
        if (triangle_shop)
        {
            beli[0].gameObject.SetActive(false);
            telahbeli[0].gameObject.SetActive(true);

            lockPanel[0].gameObject.SetActive(false);
        }
        if (sixSide_shop)
        {
            beli[1].gameObject.SetActive(false);
            telahbeli[1].gameObject.SetActive(true);

            lockPanel[1].gameObject.SetActive(false);
        }
        if (ceper_shop)
        {
            beli[2].gameObject.SetActive(false);
            telahbeli[2].gameObject.SetActive(true);

            lockPanel[2].gameObject.SetActive(false);
        }
        if (capsule_shop)
        {
            beli[3].gameObject.SetActive(false);
            telahbeli[3].gameObject.SetActive(true);

            lockPanel[3].gameObject.SetActive(false);
        }
        if (O_shop)
        {
            beli[4].gameObject.SetActive(false);
            telahbeli[4].gameObject.SetActive(true);

            lockPanel[4].gameObject.SetActive(false);
        }
    }

}
