using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORECOUNT : MonoBehaviour
{
    public Text hiText;
    public int HighScore = 0;
    public int GameMode;





    // Update is called once per frame
    void Update()
    {
        //Get the constant gamemode
        GameMode = PlayerPrefs.GetInt("GameMode", 1);
        if (GameMode == 1)
        {
            // set highscore for game mode 1
            HighScore = PlayerPrefs.GetInt("HighScore", 0);

        }
        if (GameMode == 2)
        {

            HighScore = PlayerPrefs.GetInt("HighScore2", 0);
        }
        if (GameMode == 3)
        {
            HighScore = PlayerPrefs.GetInt("HighScore3", 0);
        }
        if (GameMode == 4)
        {
            HighScore = PlayerPrefs.GetInt("HighScore4", 0);
        }
        if (GameMode == 5)
        {
            HighScore = PlayerPrefs.GetInt("HighScore5", 0);
        }


        //set the Highscore text
        hiText.text = HighScore.ToString();



    }
}
