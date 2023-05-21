using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPower : MonoBehaviour
{
    public GameObject Player;



    void Update()
    {
        transform.position = Player.transform.position;

    }

}
