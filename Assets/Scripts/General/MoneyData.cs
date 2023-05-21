using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MoneyData
{
    public int money;
    public int tiket;

    public MoneyData()
    {
        money = money_player.money;
        tiket = tickets.tiket;
    }
}
