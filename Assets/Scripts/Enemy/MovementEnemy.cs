using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float rotate;
    float realSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        realSpeed = Random.Range(speed, speed + 4);

    }

    // Update is called once per frame
    void Update()
    {
        //rotate
        transform.Rotate(new Vector3(0, 0, rotate * Time.deltaTime));

        //movement
        transform.position = Vector2.MoveTowards(transform.position, player.position, realSpeed * Time.deltaTime);
    }


}
