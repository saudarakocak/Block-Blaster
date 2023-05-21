using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tickets : MonoBehaviour
{
    public static int tiket;
    public TMP_Text tiketText;

    private void Start()
    {
        var x = SaveSystem.LoadDataMoney();
        if (x != null)
        {
            tiket = x.tiket;
        }else
        {
            tiket = 0;
        }
    }

    private void Update()
    {
        tiketText.text = tiket.ToString();
    }
}
