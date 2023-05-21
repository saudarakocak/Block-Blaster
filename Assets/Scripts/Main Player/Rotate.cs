using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public Rigidbody2D player;
    public GameObject buttonON, buttonOFF;
    bool isReady, isON;
    public float cooldownTime;
    float CooldownTemp;
    public Slider slider;

    private void Start()
    {
        CooldownTemp = cooldownTime;
        isReady = true;
    }

    private void Update()
    {
        slider.value = cooldownTime;
        if (isReady)
        {
            buttonON.gameObject.SetActive(true);
            buttonOFF.gameObject.SetActive(false);
            slider.gameObject.SetActive(false);
        }else
        {
            buttonON.gameObject.SetActive(false);
            buttonOFF.gameObject.SetActive(true);
            slider.gameObject.SetActive(true);
        }

        
        if (isON)
        {
            cooldownTime -= Time.deltaTime;
            if (cooldownTime <= 0)
            {
                isON = false;
                cooldownTime = CooldownTemp;
                isReady = true;
            }
        }

    }


    public void StopRotating()
    {
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
        player.constraints = RigidbodyConstraints2D.None;
        isON = true;
        isReady = false;
    }
}
