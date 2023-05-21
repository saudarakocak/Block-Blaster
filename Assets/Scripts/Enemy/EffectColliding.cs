using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectColliding : MonoBehaviour
{
    public GameObject effect;
    private Score point;
    private HealthPlayer health;
    public bool isBoss;

    public void enemyDestroy()
    {
        Destroy(gameObject);
        Spawner.JumlahEnemey--;
    }

    private void Start()
    {
        point = GameObject.FindGameObjectWithTag("Player").GetComponent<Score>();
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthPlayer>();
    }
    private void Update()
    {
        if (HealthPlayer.playerDeath == true)
        {
            enemyDestroy();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            FindObjectOfType<AudioManager>().Play("TouchEnemy");
            point.score++ ;
            Instantiate(effect, transform.position, Quaternion.identity);
            enemyDestroy();
        }else if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("Dead");
            if (!isBoss)
            {
                health.health--;
            }else
            {
                health.health -= 2;
            }
            Instantiate(effect, transform.position, Quaternion.identity);
            enemyDestroy();
        }
        else if (collision.gameObject.tag == "ground")
        {
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Power")
        {
            FindObjectOfType<AudioManager>().Play("Landing");
            Instantiate(effect, transform.position, Quaternion.identity);
            enemyDestroy();
        }
    }
}
