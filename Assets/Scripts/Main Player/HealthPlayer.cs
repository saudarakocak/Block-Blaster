using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    public float health;
    public float cooldownTime;
    public float time;
    public Animator GameOverUI;
    public GameObject GameOverUIPanel;
    private Score score;
    public GameObject highscoreIT, highscoreText;
    public Slider slider;
    public static bool playerDeath;

    public void GameOver()
    {
        playerDeath = true;
        SaveSystem.SaveDataMoney();
        if (score.score > score.highScore)
        {
            highscoreText.gameObject.SetActive(false);
            highscoreIT.gameObject.SetActive(true);
            SaveSystem.SaveData(score);
        }

        GameOverUI.SetBool("Dead", true);
        GameOverUIPanel.gameObject.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Dead");
        FindObjectOfType<AudioManager>().Stop("Backsound");
        gameObject.SetActive(false);
        
    }

    private void Start()
    {
        playerDeath = false;
        score = FindObjectOfType<Score>();
        time = cooldownTime;
    }

    private void Update()
    {
        slider.value = health;
        if (health < 5 && health > 0)
        {
            health += Time.deltaTime / 3;
        }
        if (health <= 0)
        {
            GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            time = cooldownTime;
        }else if (collision.gameObject.tag == "Boss")
        {
            time = cooldownTime;
        }
    }
}
