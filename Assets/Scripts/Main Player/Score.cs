using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText, highscoreText;
    public int highScore = 0;



    private void Start()
    {
        GameData data = SaveSystem.LoadData();
        highScore = data.score;
        highscoreText.text = "Highscore : " + highScore;

    }

    private void Update()
    {
        if (HealthPlayer.playerDeath == false)
        scoreText.text = "Score : " + score;
    }
}
