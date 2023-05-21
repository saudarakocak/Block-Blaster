using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skin_gameplay : MonoBehaviour
{
    public SpriteRenderer playerSprite;
    public Sprite[] spriteCollection;

    public BoxCollider2D boxCollider2D;
    public PolygonCollider2D[] polygonCollider2Ds;
    public CircleCollider2D circleCollider2D;

    void allOffSkin()
    {
        //collider
        boxCollider2D.enabled = false;
        for(int i = 0; i < polygonCollider2Ds.Length; i++)
        {
            polygonCollider2Ds[i].enabled = false;
        }
        circleCollider2D.enabled = false;
    }

    private void Start()
    {
        allOffSkin();
    }

    private void Update()
    {
        switch (skin.patokan_digunakan)
        {
            case 0:
                playerSprite.sprite = spriteCollection[0];
                boxCollider2D.enabled = true;
                break;
            case 1:
                playerSprite.sprite = spriteCollection[1];
                polygonCollider2Ds[0].enabled = true;
                break;
            case 2:
                playerSprite.sprite = spriteCollection[2];
                polygonCollider2Ds[1].enabled = true;
                break;
            case 3:
                playerSprite.sprite = spriteCollection[3];
                polygonCollider2Ds[2].enabled = true;
                break;
            case 4:
                playerSprite.sprite = spriteCollection[4];
                polygonCollider2Ds[3].enabled = true;
                break;
            case 5:
                playerSprite.sprite = spriteCollection[5];
                circleCollider2D.enabled = true;
                break;
        }
    }
}
