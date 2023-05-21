using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerManager : MonoBehaviour
{
    bool aktif = false;
    public float Duration = 10;
    public GameObject ThePower;

    [Header("UI")]
    public GameObject ONImage;
    public GameObject OffImage;
    public GameObject EmptyImage;
    public Slider slider;
    // Update is called once per frame
    void Update()
    {
        if (Duration < 10)
        {
            slider.gameObject.SetActive(true);
        }else
        {
            slider.gameObject.SetActive(false);
        }

        slider.value = Duration;

        if (Duration > 0)
        {
            ONImage.gameObject.SetActive(true);
            EmptyImage.gameObject.SetActive(false);
            if (aktif)
            {
                ONImage.gameObject.SetActive(false);
                OffImage.gameObject.SetActive(true);
                Duration -= Time.deltaTime;
                ThePower.gameObject.SetActive(true);
            }
        }else
        {
            ONImage.gameObject.SetActive(false);
            OffImage.gameObject.SetActive(false);
            EmptyImage.gameObject.SetActive(true);
            ThePower.gameObject.SetActive(false);
            aktif = false;
        }
    }


    public void ON()
    {
        FindObjectOfType<AudioManager>().Play("GetItem");
        Duration -= 2;
        aktif = true;

    }

    public void Off()
    {
        aktif = false;
        ThePower.gameObject.SetActive(false);
        ONImage.gameObject.SetActive(true);
        OffImage.gameObject.SetActive(false);
    }

    public void EmptyButton()
    {
        FindObjectOfType<AudioManager>().Play("ShieldEmpty");
    }
}
