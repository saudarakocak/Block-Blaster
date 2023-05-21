using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerItem : MonoBehaviour
{
    private PowerManager power;

    private void Start()
    {
        power = GameObject.FindGameObjectWithTag("ItemButton").GetComponent<PowerManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            power.Duration = 10;
        }
    }
}
