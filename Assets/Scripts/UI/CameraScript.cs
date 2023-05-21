using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    public Animator cameraAnimasi;
    public float cooldownDelay;
    private float time;
    bool start;
    private HealthPlayer health;
    [Header("UI Zoom")]
    public GameObject ButtonOn, ButttonOff;
    public Slider Slider;
    [Header("UI BloodEffect")]
    public GameObject BloodEffectCamera;
    public Animator BloodEffect;



    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Backsound");
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthPlayer>();
        time = cooldownDelay;
    }

    private void Update()
    {


        if (start)
        {
            ButtonOn.gameObject.SetActive(false);
            ButttonOff.gameObject.SetActive(true);
            time -= Time.deltaTime;
            Slider.gameObject.SetActive(true);
            Slider.value = time;
            if (time <= 0)
            {
                start = false;
            }
        }
        else
        {
            time = cooldownDelay;
            ButtonOn.gameObject.SetActive(true);
            ButttonOff.gameObject.SetActive(false);
            Slider.gameObject.SetActive(false);
        }


        if (health.health <= 4 && health.health > 2)
        {
            BloodEffectCamera.gameObject.SetActive(true);
            BloodEffect.SetBool("Bloody", true);
            BloodEffect.SetBool("X", false);

        }
        else if (health.health <= 2)
        {
            BloodEffectCamera.gameObject.SetActive(true);
            BloodEffect.SetBool("Bloody", true);
            BloodEffect.SetBool("X", true);
        }
        else
        {
            BloodEffectCamera.gameObject.SetActive(false);
            BloodEffect.SetBool("Bloody", false);
            BloodEffect.SetBool("X", false);

        }

    }

    public void ZoomOut()
    {
        cameraAnimasi.SetBool("ZoomOut", true);
        Invoke("ZoomOutEnd", 3);
        start = true;

    }

    private void ZoomOutEnd()
    {
        cameraAnimasi.SetBool("ZoomOut", false);
    }

}
