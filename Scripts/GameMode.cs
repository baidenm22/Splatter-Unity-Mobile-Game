using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    public int Gamemode;
    public Image ColorButton1;
    public Text GameName;
  


    // Start is called before the first frame update
    void Start()
    {
        Gamemode = PlayerPrefs.GetInt("GameMode", 1);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("GameMode", Gamemode);
        PlayerPrefs.Save();

        //WhichColor button to active?
        if (Gamemode == 1)
        {
            ColorButton1.GetComponent<Image>().color = new Color(241/255f, 44/255f, 48/255f);
            GameName.text = "Classic";
        } 
        if (Gamemode == 2)
        {
            ColorButton1.GetComponent<Image>().color = new Color(241/255f, 44/255f, 184/255f);
            GameName.text = "Drag";
        }
        if (Gamemode == 3)
        {
            ColorButton1.GetComponent<Image>().color = new Color(0 / 255f, 214 / 255f, 168 / 255f);
            GameName.text = "Precision";
        }
        if (Gamemode == 4)
        {
            ColorButton1.GetComponent<Image>().color = new Color(255 / 255f, 134 / 255f, 0 / 255f);
            GameName.text = "Lights";
        }
        if (Gamemode == 5)
        {
            ColorButton1.GetComponent<Image>().color = new Color(174 / 255f, 235 / 255f, 255 / 255f);
            GameName.text = "Ghost";
        }
    }


    public void addGameMode()
    {
        if (Gamemode < 5)
        {
            Gamemode += 1;
        } else
        {
            Gamemode = 1;
        }


    }
    public void subGameMode()
    {
        if(Gamemode > 1)
        {
            Gamemode -= 1;
        } else
        {
            Gamemode = 5;
        }

    }
}
