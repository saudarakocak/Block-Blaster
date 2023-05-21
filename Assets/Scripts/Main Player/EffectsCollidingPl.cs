using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsCollidingPl : MonoBehaviour
{
    public Animator MainCamera;
    public GameObject Danger_Text;
    public AnimationPlayer animasi;
    float time = 2;
    bool yes = false;
    public ParticleSystem portalFx;
    public GameObject portalUIFx;

    private void Start()
    {
        portalFx.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (yes)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                FindObjectOfType<HealthPlayer>().GameOver();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EndWorld")
        {
            Danger_Text.gameObject.SetActive(true);
            yes = true;
            FindObjectOfType<AudioManager>().Play("OutsideTheRange");
        }
        else if (collision.gameObject.tag == "Shield")
        {
            animasi.TouchItemAnimation();
            FindObjectOfType<AudioManager>().Play("GetItem");
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Portal")
        {
            FindObjectOfType<AudioManager>().Play("teleport");
            FindObjectOfType<AudioManager>().Play("epek");
            portalUIFx.gameObject.SetActive(true);
            portalFx.gameObject.SetActive(true);
            portalFx.Play();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EndWorld")
        {
            FindObjectOfType<AudioManager>().Stop("OutsideTheRange");
            Danger_Text.gameObject.SetActive(false);
            yes = false;
            time = 5;
        } 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            MainCamera.SetBool("Shaky", true);
            Invoke("unshaky", 0.3f);
            animasi.TouchEnemyAnimation();
        }else if (collision.gameObject.tag == "Boss")
        {
            MainCamera.SetBool("Shaky", true);
            Invoke("unshaky", 0.3f);
            animasi.TouchEnemyAnimation();
        }
        else if (collision.gameObject.tag == "ground")
        {
            FindObjectOfType<AudioManager>().Play("Landing");
        }
    }

    void unshaky()
    {
        MainCamera.SetBool("Shaky", false);
    }
}
