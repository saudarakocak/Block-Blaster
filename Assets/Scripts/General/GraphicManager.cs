using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicManager : MonoBehaviour
{
    public GameObject PostPrObj;
    public int copy;

    private void Update()
    {
        copy = Post.check;

        if(copy == 0)
        {
            PostPrObj.gameObject.SetActive(false);
        }else
        {
            PostPrObj.gameObject.SetActive(true);
        }
    }
            
}
