using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector]
    public bool inStore;
    SpriteRenderer rPlayer;
    GameObject player;
    [HideInInspector]
    public GameObject Screen1, Screen2, Screen3, Screen4, Screen5;
    void Start()
    {
        inStore = false;      
        Screen1 = GameObject.FindGameObjectWithTag("Screen1");
        Screen2 = GameObject.FindGameObjectWithTag("Screen2");
        Screen3 = GameObject.FindGameObjectWithTag("Screen3");
        Screen4 = GameObject.FindGameObjectWithTag("Screen4");
        player = GameObject.FindGameObjectWithTag("Player");
        rPlayer = player.transform.GetChild(1).GetComponent<SpriteRenderer>();
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);


    }  
    public void SelectStore()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(true);
    }

    public void SelectWardrope()
    {
        if(Screen1.activeSelf)
        {
            Screen1.SetActive(false);
        }
        if (Screen4.activeSelf)
        {
            Screen4.SetActive(false);
        }
        Screen3.SetActive(true);
    }

    public void BackFromHUD()
    {
        if (Screen4.activeSelf && !inStore)
        {
            Screen4.SetActive(false);
        }
        else if (Screen1.activeSelf)
        {
            Screen1.SetActive(false);
            inStore = false;
        }
        player.transform.GetComponent<Move>().enabled = true;

    }
    

    #region store
    //this part is the buttons in the store
    public void C1()
    {
        if(player.GetComponent<Interactions>().coins >=100)
        {
            Screen3.transform.GetChild(1).gameObject.SetActive(true);
            Screen2.transform.GetChild(0).gameObject.SetActive(false);
            player.GetComponent<Interactions>().coins -= 100;
        }
    }
    public void C2()
    {
        if (player.GetComponent<Interactions>().coins >= 100)
        {
            Screen3.transform.GetChild(2).gameObject.SetActive(true);
            Screen2.transform.GetChild(1).gameObject.SetActive(false);
            player.GetComponent<Interactions>().coins -= 100;
        }
    }
    public void C3()
    {
        if (player.GetComponent<Interactions>().coins >= 100)
        {
            Screen3.transform.GetChild(3).gameObject.SetActive(true);
            Screen2.transform.GetChild(2).gameObject.SetActive(false);
            player.GetComponent<Interactions>().coins -= 100;
        }
    }
    public void C4()
    {
        if (player.GetComponent<Interactions>().coins >= 100)
        {
            Screen3.transform.GetChild(4).gameObject.SetActive(true);
            Screen2.transform.GetChild(3).gameObject.SetActive(false);
            player.GetComponent<Interactions>().coins -= 100;
        }
    }
    public void C5()
    {
        if (player.GetComponent<Interactions>().coins >= 100)
        {
            Screen3.transform.GetChild(5).gameObject.SetActive(true);
            Screen2.transform.GetChild(4).gameObject.SetActive(false);
            player.GetComponent<Interactions>().coins -= 100;
        }
    }
    #endregion

    #region wardrope
    //this part set the cloth the player can choose 
    public void HC0()
    {
        rPlayer.material.color = Color.white;
    }
    public void HC1()
    {
        rPlayer.material.color = Color.red;
    }
    public void HC2()
    {
        rPlayer.material.color = Color.blue;
    }
    public void HC3()
    {
        rPlayer.material.color = Color.green;
    }
    public void HC4()
    {
        rPlayer.material.color = Color.yellow;
    }
    public void HC5()
    {
        rPlayer.material.color = Color.gray;
    }
    #endregion

    public void BackMainStoreMenu()
    {
        if(Screen2.activeSelf)
        {
            Screen1.SetActive(true);
            Screen2.SetActive(false);
        }
        else if(Screen3.activeSelf && inStore)
        {
            Screen1.SetActive(true);
            Screen3.SetActive(false);
        }
        else
        {
            Screen4.SetActive(true);
            Screen3.SetActive(false);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void QuitTutorial()
    {
        Screen5.SetActive(false);
    }
}
