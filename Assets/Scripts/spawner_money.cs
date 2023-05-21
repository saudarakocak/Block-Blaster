using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_money : MonoBehaviour
{
    public Transform[] pos;
    public GameObject PrefabItem;
    int patokan;
    public static bool pindahPos = false;

    private void Start()
    {
        patokan = Random.Range(0, pos.Length);
        Instantiate(PrefabItem, pos[patokan].position, Quaternion.identity);
    }

    private void Update()
    {
        if (pindahPos)
        {
            patokan = Random.Range(0, pos.Length);
            Instantiate(PrefabItem, pos[patokan].position, Quaternion.identity);
            pindahPos = false;
            Debug.LogWarning("spawnMoney");
        }
    }
}
