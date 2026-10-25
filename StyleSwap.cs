using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StyleSwap : MonoBehaviour
{

    public int skinshopnum = 0;
    public GameObject[] shops;
    public int MaxShop;

    // Start is called before the first frame update
    void Start()
    {
        skinshopnum = PlayerPrefs.GetInt("SSN", 0);
    }

    public void Next()
    {
        shops[skinshopnum].SetActive(false);
        skinshopnum += 1;
        if (skinshopnum > MaxShop)
        {
            skinshopnum = 0;
        }
        
        shops[skinshopnum].SetActive(true);
    }
    public void back()
    {
        shops[skinshopnum].SetActive(false);
        skinshopnum -= 1;
        if (skinshopnum < 0)
        {
            skinshopnum = MaxShop;
        }
        shops[skinshopnum].SetActive(true);
    }

}
