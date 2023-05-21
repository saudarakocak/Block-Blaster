using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject transisi;
    public int postPr = 0;

    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Backsound");

        //load shop skin
        skin_data s = SaveSystem.LoadDataSkin();
        if (s != null)
        {
            skin.patokan_digunakan = s.patokanSkin;
        }else
        {
            skin.patokan_digunakan = 0;
        }
        //load shop shop
        shop_data x = SaveSystem.LoadDataShop();
        if (x != null)
        {
            shop._triangle_shop = x._triangleData;
            shop._sixSide_shop = x._sixsideData;
            shop._ceper_shop = x._ceperData;
            shop._capsule_shop = x._capsuleData;
            shop._O_shop = x._oData;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private void PlayGame()
    {
        Post.check = postPr;
        transisi.gameObject.SetActive(true);
        Invoke("toGame", 0.8f);    
    }
    void toGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Ongraphic()
    {
        postPr = 1;
    }
    public void Offgraphic()
    {
        postPr = 0;
    }

    private void mainmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }








    public void PlayGameButton()
    {
        PlayGame();
    }

    public void MainMenuButton()
    {
        transisi.gameObject.SetActive(true);
        Invoke("mainmenu", 0.8f);
    }

}
