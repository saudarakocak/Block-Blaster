using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerController : MonoBehaviour
{
    public GameObject textWarning;
    public GameObject spawnerBoss;
    public Score score;

    private void Start()
    {
        textWarning.gameObject.SetActive(false);
        spawnerBoss.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (score.score >= 20)
        {
            textWarning.gameObject.SetActive(true);
            spawnerBoss.gameObject.SetActive(true);
        }
    }
}
