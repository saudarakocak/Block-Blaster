using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int score;

    public GameData (Score player)
    {
        score = player.score;
    }
}
