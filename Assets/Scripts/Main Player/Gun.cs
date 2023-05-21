using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    public GameObject central, hole;
    public ParticleSystem Fx;
    public float speedRotate, force;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public Transform ShotPoint;

    [Header("Main Player")]
    public Rigidbody2D physics;
    public float cooldown;
    public float timepivot = 1;
    bool ON;

    [Header("Gun Hot")]
    float timer;
    public GameObject gunON;
    public GameObject gunOff;
    public GameObject WaringTextHotGun;
    public float limitTimer;
    bool deadGun = false;
    public Slider slider;

    void Start()
    {
        cooldown = timepivot;
        ON = false;
    }

    // Update is called once per frame
    void Update()
    {
        //rotation Gun
        transform.RotateAround(central.transform.position, new Vector3(0, 0, 1), speedRotate * Time.deltaTime);

        //cooldown
        if (ON)
        cooldown -= Time.deltaTime;

        if (cooldown <= 0)
        {
            cooldown = timepivot;
            ON = false;
            physics.gravityScale = 0.5f;
        }


        //Gun Manager Time

        slider.value = timer;

        if (timer >= 0)
        {
            timer -= Time.deltaTime * 2;
        }
        if (timer >= limitTimer)
        {
            deadGun = true;
        }
        if (deadGun)
        {
            gunOff.gameObject.SetActive(true);
            gunON.gameObject.SetActive(false);
            WaringTextHotGun.gameObject.SetActive(true);
            if (timer <= 0)
            {
                deadGun = false;
                gunOff.gameObject.SetActive(false);
                gunON.gameObject.SetActive(true);
                WaringTextHotGun.gameObject.SetActive(false);
            }
        }

        
    }

    public void ShootGun()
    {
        timer += 1;

        FindObjectOfType<AudioManager>().Play("ShootGun");

        Fx.gameObject.SetActive(true);
        Fx.Play();

        ON = true;
        physics.gravityScale = 0.2f;
        Vector2 pos = transform.position - hole.transform.position;
        pos = pos.normalized;
        physics.AddForce(pos * force);

        GameObject Bullet = Instantiate(bulletPrefab, ShotPoint.position, ShotPoint.rotation);
        Bullet.GetComponent<Rigidbody2D>().AddForce(-Bullet.transform.right * bulletSpeed);
    }
}
