using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject x;

    void hancur()
    {
        gameObject.SetActive(false);
    }
    void objekAktif()
    {
        FindObjectOfType<AudioManager>().Play("Gacha");
        x.gameObject.SetActive(true);
    }
}
