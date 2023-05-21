using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem
{
    //SCORE
    public static void SaveData(Score player)
    {
        string path = Application.persistentDataPath + "/score.This";
        BinaryFormatter x = new BinaryFormatter();
        FileStream stram = new FileStream(path, FileMode.Create);

        GameData data = new GameData(player);

        x.Serialize(stram, data);
        stram.Close();
        Debug.Log("simpan Baru");

    }
    public static GameData LoadData()
    {
        string path = Application.persistentDataPath + "/score.This";
        if (File.Exists(path))
        {
            BinaryFormatter x = new BinaryFormatter();
            FileStream stram = new FileStream(path, FileMode.Open);

            GameData data = x.Deserialize(stram) as GameData;
            stram.Close();
            Debug.Log("load");
            return data;

        }else
        {
            Debug.Log("unload");
            return null;

        }
    }

    //MONEY
    public static void SaveDataMoney()
    {
        string path = Application.persistentDataPath + "/money.This";
        BinaryFormatter x = new BinaryFormatter();
        FileStream stram = new FileStream(path, FileMode.Create);

        MoneyData data = new MoneyData();

        x.Serialize(stram, data);
        stram.Close();
        Debug.Log("simpan Baru");

    }
    public static MoneyData LoadDataMoney()
    {
        string path = Application.persistentDataPath + "/money.This";
        if (File.Exists(path))
        {
            BinaryFormatter x = new BinaryFormatter();
            FileStream stram = new FileStream(path, FileMode.Open);

            MoneyData data = x.Deserialize(stram) as MoneyData;
            stram.Close();
            Debug.Log("load");
            return data;

        }
        else
        {
            Debug.Log("unload");
            return null;

        }
    }
    //SKIN
    public static void SaveDataSkin(skin_player skin)
    {
        string path = Application.persistentDataPath + "/skin.This";
        BinaryFormatter x = new BinaryFormatter();
        FileStream stram = new FileStream(path, FileMode.Create);

        skin_data data = new skin_data(skin);

        x.Serialize(stram, data);
        stram.Close();
        Debug.Log("simpan Baru");

    }
    public static skin_data LoadDataSkin()
    {
        string path = Application.persistentDataPath + "/skin.This";
        if (File.Exists(path))
        {
            BinaryFormatter x = new BinaryFormatter();
            FileStream stram = new FileStream(path, FileMode.Open);

            skin_data data = x.Deserialize(stram) as skin_data;
            stram.Close();
            Debug.Log("load");
            return data;
        }
        else
        {
            Debug.Log("unload");
            return null;

        }
    }
    //SHOP
    public static void SaveDataShop(shop shop)
    {
        string path = Application.persistentDataPath + "/shop.This";
        BinaryFormatter x = new BinaryFormatter();
        FileStream stram = new FileStream(path, FileMode.Create);

        shop_data data = new shop_data(shop);

        x.Serialize(stram, data);
        stram.Close();
        Debug.Log("simpan Baru");

    }
    public static shop_data LoadDataShop()
    {
        string path = Application.persistentDataPath + "/shop.This";
        if (File.Exists(path))
        {
            BinaryFormatter x = new BinaryFormatter();
            FileStream stram = new FileStream(path, FileMode.Open);

            shop_data data = x.Deserialize(stram) as shop_data;
            stram.Close();
            Debug.Log("load");
            return data;
        }
        else
        {
            Debug.Log("unload");
            return null;

        }
    }
}
