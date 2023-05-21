using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class shop_data
{
    public bool _triangleData, _sixsideData, _ceperData, _capsuleData, _oData;
    public shop_data(shop shop)
    {
        _triangleData = shop.triangle_shop;
        _sixsideData = shop.sixSide_shop;
        _ceperData = shop.ceper_shop;
        _capsuleData = shop.capsule_shop;
        _oData = shop.O_shop;
    }
}
