using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StyleShop : MonoBehaviour
{

    private int gemcount;
    public int cost;
    public GameObject cover;
    public bool one;
    public bool two;
    public bool three;
    public bool four;
    public bool five;
    public bool og;
    public bool six;
    public bool seven;
    public bool eight;
    public bool nine;
    public bool ten;



  
    // Update is called once per frame
    void Update()
    {
        gemcount = PlayerPrefs.GetInt("Gem", 0);
       if (one == true)
        {
            if(PlayerPrefs.GetInt("1Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
        if (two == true)
        {
            if (PlayerPrefs.GetInt("2Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
        if (three == true)
        {
            if (PlayerPrefs.GetInt("3Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
        if (four == true)
        {
            if (PlayerPrefs.GetInt("4Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
        if (five == true)
        {
            if (PlayerPrefs.GetInt("5Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
        if (six == true)
        {
            if (PlayerPrefs.GetInt("6Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
        if (seven == true)
        {
            if (PlayerPrefs.GetInt("7Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
        if (eight == true)
        {
            if (PlayerPrefs.GetInt("8Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
        if (nine == true)
        {
            if (PlayerPrefs.GetInt("9Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
        if (ten == true)
        {
            if (PlayerPrefs.GetInt("10Bought", 0) == 1)
            {
                cover.SetActive(false);
            }
        }
    }
    public void pay()
    {
        if (one == true)
        {
            if (PlayerPrefs.GetInt("1Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("1Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }
        }
        if (two == true)
        {
            if (PlayerPrefs.GetInt("2Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("2Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }
        }
        if (three == true)
        {
            if (PlayerPrefs.GetInt("3Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("3Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }
        }
        if (four == true)
        {
            if (PlayerPrefs.GetInt("4Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("4Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }
        }
        if (five == true)
        {
            if (PlayerPrefs.GetInt("5Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("5Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }
        }
        if (six == true)
        {
            if (PlayerPrefs.GetInt("6Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("6Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }
        }
        if (seven == true)
        {
            if (PlayerPrefs.GetInt("7Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("7Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }
        }
        if (eight == true)
        {
            if (PlayerPrefs.GetInt("8Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("8Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }

        }
        if (nine == true)
        {
            if (PlayerPrefs.GetInt("9Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("9Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }
        }
        if (ten == true)
        {
            if (PlayerPrefs.GetInt("10Bought", 0) == 0 && gemcount >= cost)
            {
                PlayerPrefs.SetInt("10Bought", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) - cost);
            }
        }
    }
    public void apply()
    {
        if (one == true)
        {
            PlayerPrefs.SetInt("Skin", 1);
        }
        if (two == true)
        {
            PlayerPrefs.SetInt("Skin", 2);
        }
        if (three == true)
        {
            PlayerPrefs.SetInt("Skin", 3);
        }
        if (four == true)
        {
            PlayerPrefs.SetInt("Skin", 4);
        }
        if (five == true)
        {
            PlayerPrefs.SetInt("Skin", 5);
        }
        if (og == true)
        {
            PlayerPrefs.SetInt("Skin", 0);
        }
        if (six == true) {
             PlayerPrefs.SetInt("Skin", 6);
        }
        if (seven == true)
        {
            PlayerPrefs.SetInt("Skin", 7);
        }
        if (eight == true)
        {
            PlayerPrefs.SetInt("Skin", 8);
        }
        if (nine == true)
        {
            PlayerPrefs.SetInt("Skin", 9);
        }
        if (ten == true)
        {
            PlayerPrefs.SetInt("Skin", 10);
        }
    }
}
