using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skin : MonoBehaviour
{
    public GameObject[] gunakan;
    public GameObject[] digunakan;
    public static int patokan_digunakan;

    public void allOnGunakan()
    {
        for (int i = 0; i < gunakan.Length; i++)
        {
            gunakan[i].gameObject.SetActive(true);
        }
    }
    public void alloffDigunakan()
    {
        for (int i = 0; i < gunakan.Length; i++)
        {
            digunakan[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        ButtonId();
    }

    public void Tombol(int x)
    {
        allOnGunakan();
        alloffDigunakan();

        patokan_digunakan = x;
        FindObjectOfType<AudioManager>().Play("Used");
    }

    void ButtonId()
    {
        switch (patokan_digunakan)
        {
            case 0:
                gunakan[0].gameObject.SetActive(false);
                digunakan[0].gameObject.SetActive(true);
                break;
            case 1:
                gunakan[1].gameObject.SetActive(false);
                digunakan[1].gameObject.SetActive(true);
                break;
            case 2:
                gunakan[2].gameObject.SetActive(false);
                digunakan[2].gameObject.SetActive(true);
                break;
            case 3:
                gunakan[3].gameObject.SetActive(false);
                digunakan[3].gameObject.SetActive(true);
                break;
            case 4:
                gunakan[4].gameObject.SetActive(false);
                digunakan[4].gameObject.SetActive(true);
                break;
            case 5:
                gunakan[5].gameObject.SetActive(false);
                digunakan[5].gameObject.SetActive(true);
                break;

        }
    }
}
