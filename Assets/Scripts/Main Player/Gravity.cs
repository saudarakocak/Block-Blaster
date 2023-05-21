using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravityPower;
    public GameObject player;
    public bool move;

    private void Update()
    {
        if (move)
        {
            player.transform.position = Vector2.MoveTowards(player.transform.position, gameObject.transform.position, gravityPower / 10);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            move = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            move = false;
        }
    }
}
