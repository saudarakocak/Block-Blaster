using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tressure : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("treassure");
            spawner_money.pindahPos = true;
            money_player.money += 20;
            Destroy(gameObject);
        }
    }
}
