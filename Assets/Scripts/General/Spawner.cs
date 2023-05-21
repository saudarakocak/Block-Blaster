using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject GameObject;
    public Vector2 min, max;
    public float timeSpawn;
    public static int JumlahEnemey;
    public Transform parentofEnemy;

    float time = 0;
    float duration = 0;

    private void Start()
    {
        time = timeSpawn;
    }

    void Update()
    {
        if (HealthPlayer.playerDeath == true)
        {
            Destroy(this.gameObject);
        }

        Debug.Log(JumlahEnemey);

        time -= Time.deltaTime;

        float randomX = Random.Range(min.x, max.x);
        float randomY = Random.Range(min.y, max.y);

        Vector2 posisi = new Vector2(randomX, randomY);

        if (time <= 0 && JumlahEnemey <= 40)
        {
            Instantiate(GameObject, posisi, Quaternion.identity, parentofEnemy);
            time = timeSpawn;
            duration++;
            JumlahEnemey++;
        }
    
        if (duration >= 100)
        {
            timeSpawn = 0.15f;
        }

    }
}
