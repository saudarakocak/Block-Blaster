using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class money_player : MonoBehaviour
{
    public static int money;
    public TMP_Text moneyText;

    private void Start()
    {
        MoneyData x = SaveSystem.LoadDataMoney();
        if (x != null)
        {
            money = x.money;
        }else
        {
            money = 0;
        }
    }
    private void Update()
    {
        moneyText.text = "$ " + money;
    }
}
