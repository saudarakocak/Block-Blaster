using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gacha : MonoBehaviour
{
    float randomize = 0;
    bool startRandomize;
    //public float randomizeTime;
    float tempTime;
    public GameObject[] hadiah;
    public TMP_Text nama;
    int patokan;
    public shop_data shopdata;
    public shop shopp;
    public TMP_Text tiketTidakCukup;
    public GameObject animasi;
    public GameObject panel;

    private void Start()
    {
        panel.gameObject.SetActive(false);
        //tempTime = randomizeTime;
    }

    private void Update()
    {
        pemberianHadiah();
    }

    public void StartGacha()
    {
        if (tickets.tiket >= 5)
        {
            tickets.tiket -= 5;
            allHadiahOff();
            randomize = Random.Range(0, 100);
            SaveSystem.SaveDataMoney();
            animasi.gameObject.SetActive(true);
            panel.gameObject.SetActive(true);
        }else
        {
            tiketTidakCukup.gameObject.SetActive(true);
            panel.gameObject.SetActive(false);
        }
    }

    void allHadiahOff()
    {
        for(int i = 0; i < hadiah.Length; i++)
        {
            hadiah[i].gameObject.SetActive(false);
        }
    }

    public void get()
    {
        switch (patokan)
        {
            case 0:
                money_player.money += 10;
                SaveSystem.SaveDataMoney();
                break;
            case 1:
                Debug.Log("zonk");
                break;
            case 2:
                shopp.triangle_shop = true;
                SaveSystem.SaveDataShop(shopp);
                break;
            case 3:
                shopp.sixSide_shop = true;
                SaveSystem.SaveDataShop(shopp);
                break;
            case 4:
                shopp.ceper_shop = true;
                SaveSystem.SaveDataShop(shopp);
                break;
            case 5:
                shopp.capsule_shop = true;
                SaveSystem.SaveDataShop(shopp);
                break;
            case 6:
                shopp.O_shop = true;
                SaveSystem.SaveDataShop(shopp);
                break;

        }
    }

    void pemberianHadiah()
    {
        if (randomize >= 0 && randomize <= 25)
        {
            patokan = 0;
            nama.text = "Money";
            hadiah[0].gameObject.SetActive(true);
        }else if(randomize > 25 && randomize <= 50)
        {
            patokan = 1;
            nama.text = "Zonk";
            hadiah[1].gameObject.SetActive(true);
        }else if (randomize > 50 && randomize <= 60)
        {
            patokan = 2;
            nama.text = "Triangle Blaster";
            hadiah[2].gameObject.SetActive(true);
        }else if (randomize > 60 && randomize <= 70)
        {
            patokan = 3;
            nama.text = "Sixside Blaster";
            hadiah[3].gameObject.SetActive(true);
        }else if (randomize > 70 && randomize <= 80)
        {
            patokan = 4;
            nama.text = "Ceper Blaster";
            hadiah[4].gameObject.SetActive(true);
        }else if (randomize > 80 && randomize <= 90)
        {
            patokan = 5;
            nama.text = "Capsule Blaster";
            hadiah[5].gameObject.SetActive(true);
        }else if (randomize > 90 && randomize <= 100)
        {
            patokan = 6;
            nama.text = "O Blaster";
            hadiah[6].gameObject.SetActive(true);
        }
    }
}
