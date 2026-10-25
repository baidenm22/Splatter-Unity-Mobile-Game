using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public int HighScore = 0;
    public GameObject GameManager;
    public bool runScoreCheck = false;
    public int Gamemode;

    // Start is called before the first frame update
    void Start()
    {
        //Get Gamemode
        Gamemode = PlayerPrefs.GetInt("GameMode", 1);
        //Get HighScore
        if (Gamemode == 1)
        {
            HighScore = PlayerPrefs.GetInt("HighScore", 0);
        } else if (Gamemode == 2)
        {
            HighScore = PlayerPrefs.GetInt("HighScore2", 0);
        } else if (Gamemode == 3)
        {
            HighScore = PlayerPrefs.GetInt("HighScore3", 0);
        } else if (Gamemode == 4)
        {
            HighScore = PlayerPrefs.GetInt("HighScore4", 0);
        } else if (Gamemode == 5)
        {
            HighScore = PlayerPrefs.GetInt("HighScore5", 0);
        }
    }
    void CheckScore()
    {
        //See if its bigger
        if (GameManager.GetComponent<Touch>().Points > HighScore)
        {
            //Save it if it is bigger
            if (Gamemode == 1)
            {
                HighScore = GameManager.GetComponent<Touch>().Points;
                PlayerPrefs.SetInt("HighScore", GameManager.GetComponent<Touch>().Points);
                PlayerPrefs.Save();

            } else if (Gamemode == 2)
            {
                HighScore = GameManager.GetComponent<Touch>().Points;
                PlayerPrefs.SetInt("HighScore2", GameManager.GetComponent<Touch>().Points);
                PlayerPrefs.Save();


            }else if (Gamemode == 3)
            {
                HighScore = GameManager.GetComponent<Touch>().Points;
                PlayerPrefs.SetInt("HighScore3", GameManager.GetComponent<Touch>().Points);
                PlayerPrefs.Save();


            } else if (Gamemode == 4)
            {
                HighScore = GameManager.GetComponent<Touch>().Points;
                PlayerPrefs.SetInt("HighScore4", GameManager.GetComponent<Touch>().Points);
                PlayerPrefs.Save();
            } else if (Gamemode == 5)
            {
                HighScore = GameManager.GetComponent<Touch>().Points;
                PlayerPrefs.SetInt("HighScore5", GameManager.GetComponent<Touch>().Points);
                PlayerPrefs.Save();

            }
        }

    }
    private void Update()
    {
        if (runScoreCheck == true)
        {

            CheckScore();
            runScoreCheck = false;
        }
    }
}
