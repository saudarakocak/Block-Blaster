using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class skin_data
{
    public int patokanSkin;

    public skin_data(skin_player x)
    {
        patokanSkin = skin.patokan_digunakan;
    }
}
