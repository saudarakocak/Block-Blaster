using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("coin");
            spawner_money.pindahPos = true;
            money_player.money += 1;
            Destroy(gameObject);
        }
    }
}
