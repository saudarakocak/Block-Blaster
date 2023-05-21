using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyUp : MonoBehaviour
{
    public void Awake()
    {
        Time.timeScale = 0;
    }


    public void Ready()
    {
        Time.timeScale = 1;
    }
}
