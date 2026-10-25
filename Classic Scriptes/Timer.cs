using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

  
    public float countDown = 10f;
    public Text TTimer;
    public GameObject gameManager;

    public int gamemode;

    public GameObject BackGround;

    private void Start()
    {
        gamemode = PlayerPrefs.GetInt("GameMode", 1);
        if (PlayerPrefs.GetInt("GameMode", 1) == 1)
        {
            countDown += PlayerPrefs.GetInt("CTULvl", 0);

        }
        if (PlayerPrefs.GetInt("GameMode", 1) == 2)
        {
            countDown += PlayerPrefs.GetInt("DTULvl", 0);
        }
        if (PlayerPrefs.GetInt("GameMode", 1) == 4)
        {
            countDown += PlayerPrefs.GetInt("LTULvl", 0);
        }
    }


    // Update is called once per frame
    void Update()
    {
       

        if (countDown > 0)
        {
            countDown -= Time.deltaTime;
            TTimer.text = Mathf.Round(countDown).ToString();

        } else
        {
            //END GAME
            gameManager.GetComponent<Touch>().enabled = false;
            gameManager.GetComponent<SaveData>().runScoreCheck = true;
            gameManager.GetComponent<Restart>().enabled = true;
            gameManager.GetComponent<ChallenCheck>().GameEnd = true;

            if (gamemode == 4)
            {
                BackGround.GetComponent<BackGroundColor>().enabled = false;
            }

            

        }



    }
}
