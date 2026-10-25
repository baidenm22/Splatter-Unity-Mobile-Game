using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlGate : MonoBehaviour
{

    public int GateLvl;
    private int CHLvl;

    public bool gameModeGate;
    private int GameMode;
    public Text LvGText;
    public GameObject LvlHolder;
    // Start is called before the first frame update
    void Start()
    {
        CHLvl = PlayerPrefs.GetInt("CHLvl", 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        GameMode = PlayerPrefs.GetInt("GameMode");
        if (CHLvl < GateLvl)
        {
            this.GetComponent<Image>().enabled = true;
            LvlHolder.SetActive(true);

        } else
        {
            this.GetComponent<Image>().enabled = false;
            LvlHolder.SetActive(false);
        }
     
     if (gameModeGate == true)
        {
            if (GameMode == 1)
            {
                GateLvl = 0;
                LvGText.text = 0.ToString();
            }
            if (GameMode == 2)
            {
                GateLvl = 10;
                LvGText.text = 10.ToString();
            }
            if (GameMode == 3)
            {
                GateLvl = 20;
                LvGText.text = 20.ToString();
            }
            if (GameMode == 4)
            {
                GateLvl = 30;
                LvGText.text = 30.ToString();
            }
            if (GameMode == 5)
            {
                GateLvl = 40;
                LvGText.text = 40.ToString();
            }
        }
     
    }
}
