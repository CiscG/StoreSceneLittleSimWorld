using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject canvas;
   public TextMesh coinsText;
    public int coins = 0;
    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("Respawn");
        coinsText = canvas.transform.GetChild(5).GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            canvas.GetComponent<Hud>().Screen4.SetActive(true);
            GetComponent<Move>().enabled = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Store")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                canvas.transform.GetChild(0).gameObject.SetActive(true);
                canvas.GetComponent<Hud>().inStore = true;
            }            
        }
        else if(collision.gameObject.tag == "Coin")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                coins += 100;
            }
        }
    }
}
