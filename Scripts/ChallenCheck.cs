using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallenCheck : MonoBehaviour
{

    public int ClG;
    public int ClS;
    private int Points = -1000000000;
    public bool GameEnd = false;
    public GameObject ChCT;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Chall Game Mode Value
        ClG = PlayerPrefs.GetInt("ClGM");
        //Chall Score Value
        ClS = PlayerPrefs.GetInt("ClS");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameEnd == true)
        {
            GetPoints();
        }
        if (PlayerPrefs.GetInt("GameMode", 0) == ClG)
        {
            if (Points >= ClS && PlayerPrefs.GetInt("ClC") != 1)
            {
                PlayerPrefs.SetInt("CHLvl", PlayerPrefs.GetInt("CHLvl", 0) + 1);
                ChCT.SetActive(true);
                PlayerPrefs.SetInt("ClC", 1);
                PlayerPrefs.SetInt("Gem", PlayerPrefs.GetInt("Gem", 0) + PlayerPrefs.GetInt("ClR"));
            }
        }



    }
    void GetPoints()
    {
        Points = this.GetComponent<Touch>().Points;
    }
}
