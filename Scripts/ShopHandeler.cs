using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopHandeler : MonoBehaviour
{
   

    //TU = Time Up
    //C -> Classic
    //D -> Drag
    //P -> Percision


    //Get text componets to change
    public Text Title;
    public Text Cost;

    //Get if CTU levels
    public bool ClassicTU = false;
    private int ClassTU;

    //Get if DTU levels
    public bool DragTU = false;
    private int DragTUV;

    //Get if PLE levels
    public bool PExtraLives = false;
    private int PELV;

    //Get if LTU levels
    public bool LightsTU = false;
    private int LTUV;


    // Update is called once per frame
    void Update()
    {
        //Update values
        ClassTU = PlayerPrefs.GetInt("CTULvl", 0);
        DragTUV = PlayerPrefs.GetInt("DTULvl", 0);
        PELV = PlayerPrefs.GetInt("PELvl", 0);
        LTUV = PlayerPrefs.GetInt("LTULvl", 0);

        //Check if its a Classic Time Up
        if (ClassicTU == true)
        {
            if (ClassTU != 5)
            {
                Title.text = "Time Add +" + (ClassTU + 1).ToString() + " Sec";

                Cost.text = ((ClassTU + 1) * 40).ToString();
            }
            else
            {
                Title.text = "Time Add +5 Sec";
                Cost.text = "MAX";
            }

        }
        //Check Drag Upgrades
        if (DragTU == true)
        {
            if (DragTUV != 5)
            {
                Title.text = "Time Add +" + (DragTUV + 1).ToString() + " Sec";

                Cost.text = ((DragTUV + 1) * 40).ToString();
            }
            else
            {
                Title.text = "Time Add +5 Sec";
                Cost.text = "MAX";
            }

        }
        //Check if Percision
        if (PExtraLives == true)
        {
            if (PELV != 3)
            {
                Title.text = "Extra Lives " + (PELV + 1).ToString();

                Cost.text = ((PELV + 1) * 50).ToString();
            }
            else
            {
                Title.text = "Extra Lives 3";
                Cost.text = "MAX";
            }
        }
        //Check if Lights
        if (LightsTU == true)
        {
            if (LTUV != 5)
            {
                Title.text = "Time Add +" + (LTUV + 1).ToString() + " Sec";

                Cost.text = ((LTUV + 1) * 40).ToString();
            }
            else
            {
                Title.text = "Time Add +5 Sec";
                Cost.text = "MAX";
            }

        }
    }
        public void Pay()
    {
        //Check if its a Classic Time Up
        if (ClassicTU == true)
        {
            if (ClassTU != 5 && PlayerPrefs.GetInt("Gem",0) >= (ClassTU + 1 * 40))
            {
                PlayerPrefs.SetInt("CTULvl", ClassTU + 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem") - ((ClassTU + 1) * 40));
            } else
            {
                Debug.Log("Cant Pay");
            }
        }
        //Check if its a Drag Time Up
        if (DragTU == true)
        {
            if (DragTUV != 5 && PlayerPrefs.GetInt("Gem", 0) >= (DragTUV + 1 * 40))
            {
                PlayerPrefs.SetInt("DTULvl", DragTUV + 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem") - ((DragTUV + 1) * 40));
            }
            else
            {
                Debug.Log("Cant Pay");
            }
        }
        //Check if its a Percision extra lives
        if (PExtraLives == true)
        {
            if (PELV != 3 && PlayerPrefs.GetInt("Gem", 0) >= (PELV + 1 * 50))
            {
                PlayerPrefs.SetInt("PELvl", PELV + 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem") - ((PELV + 1) * 50));
            }
            else
            {
                Debug.Log("Cant Pay");
            }
        }
        //Check if its a Drag Time Up
        if (LightsTU == true)
        {
            if (LTUV != 5 && PlayerPrefs.GetInt("Gem", 0) >= (LTUV + 1 * 40))
            {
                PlayerPrefs.SetInt("LTULvl", LTUV + 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem") - ((LTUV + 1) * 40));
            }
            else
            {
                Debug.Log("Cant Pay");
            }
        }
    }
}
