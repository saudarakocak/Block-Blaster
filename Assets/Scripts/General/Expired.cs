using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expired : MonoBehaviour
{
    public float timeEX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeEX -= Time.deltaTime;
        if (timeEX <= 0)
        {
            Destroy(gameObject);
        }
    }
}
