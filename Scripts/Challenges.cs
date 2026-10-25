using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Challenges : MonoBehaviour
{
    public int ComCh;
    public bool NewChall = false;
    public int GamemodeC;
    public int ScoreC;
    public int CLvl;
    public int Reward;
    public Text ChllTxt;
    private string ChlName;
    public Text ChlReTxt;
    public Text ChlTxtS;
    public Text ChlRTxtS;

    // Start is called before the first frame update
    void Start()
    {

        ComCh = PlayerPrefs.GetInt("ClC", 1);
        if (ComCh == 0)
        {
            NewChall = false;
        } else if (ComCh == 1)
        {
            NewChall = true;
        }

        CLvl = PlayerPrefs.GetInt("CHLvl", 0);

       if (NewChall == true)
        {
            GamemodeC = Mathf.RoundToInt(Random.Range(.5f, 5.49f));
            if (CLvl <= 10)
            {
                GamemodeC = 1;
                ScoreC = Mathf.RoundToInt(Random.Range(5, 10));
            } else if (CLvl <= 20)
            {
                GamemodeC = Mathf.RoundToInt(Random.Range(.5f, 2.49f));
                if (GamemodeC == 1)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(7, 12));
                } else if (GamemodeC == 2)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(10, 15));
                }
            }
            else if (CLvl <= 30)
            {
                GamemodeC = Mathf.RoundToInt(Random.Range(.5f, 3.49f));
                if (GamemodeC == 1)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(13, 17));
                }
                else if (GamemodeC == 2)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(10, 15));
                } else if (GamemodeC == 3)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(10, 20));
                }
            }
            else if (CLvl <= 40)
            {
                GamemodeC = Mathf.RoundToInt(Random.Range(.5f, 4.49f));
                if (GamemodeC == 1)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(12, 17));
                }
                else if (GamemodeC == 2)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(15, 20));
                }
                else if (GamemodeC == 3)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(13, 23));
                } else if (GamemodeC == 4)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(5, 15));
                }
            } else if (CLvl <= 50)
            {
                if (GamemodeC == 1)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(15, 20));
                }
                else if (GamemodeC == 2)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(20, 30));
                }
                else if (GamemodeC == 3)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(16, 26));
                }
                else if (GamemodeC == 4)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(7, 15));
                }
                else if (GamemodeC == 5)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(10, 15));
                }
            } else if (CLvl <= 60)
            {
                if (GamemodeC == 1)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(17, 23));
                }
                else if (GamemodeC == 2)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(25, 35));
                }
                else if (GamemodeC == 3)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(20, 30));
                }
                else if (GamemodeC == 4)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(15, 20));
                }
                else if (GamemodeC == 5)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(20, 30));
                }
            } else if (CLvl <= 70)
            {
                if (GamemodeC == 1)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(24, 32));
                }
                else if (GamemodeC == 2)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(35, 45));
                }
                else if (GamemodeC == 3)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(30, 60));
                }
                else if (GamemodeC == 4)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(15, 30));
                }
                else if (GamemodeC == 5)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(30, 70));
                }
            } else if (CLvl <= 80)
            {
                if (GamemodeC == 1)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(25, 35));
                }
                else if (GamemodeC == 2)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(30, 45));
                }
                else if (GamemodeC == 3)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(30, 100));
                }
                else if (GamemodeC == 4)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(25, 30));
                }
                else if (GamemodeC == 5)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(50, 100));
                }
            } else
            {
                if (GamemodeC == 1)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(30, 37));
                }
                else if (GamemodeC == 2)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(35, 50));
                }
                else if (GamemodeC == 3)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(40, 150));
                }
                else if (GamemodeC == 4)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(25, 30));
                }
                else if (GamemodeC == 5)
                {
                    ScoreC = Mathf.RoundToInt(Random.Range(60, 150));
                }
            }
           
            if (GamemodeC == 1 || GamemodeC == 2 || GamemodeC == 4)
            {
                Reward = Mathf.RoundToInt((ScoreC * 5) / 8);
            } else if (GamemodeC == 3 || GamemodeC == 5)
            {
                Reward = Mathf.RoundToInt((ScoreC / 3));
            }
            //Save these Vaules
            PlayerPrefs.SetInt("ClGM", GamemodeC);
            PlayerPrefs.SetInt("ClS", ScoreC);
            PlayerPrefs.SetInt("ClR", Reward);
            NewChall = false;
            PlayerPrefs.SetInt("ClC", 0);
        } else
        {
            GamemodeC = PlayerPrefs.GetInt("ClGM");
            ScoreC = PlayerPrefs.GetInt("ClS");
            Reward = PlayerPrefs.GetInt("ClR");
        }
    }

    // Update is called once per frame
    void Update()
    {
        



        if (GamemodeC == 1)
        {
            ChlName = "Classic";
        } else if (GamemodeC == 2)
        {
            ChlName = "Drag";
        } else if (GamemodeC == 3)
        {
            ChlName = "Precision";

        } else if (GamemodeC == 4)
        {
            ChlName = "Lights";
        } else if (GamemodeC == 5)
        {
            ChlName = "Ghost";
        }


        ChllTxt.text = "Gain a Score of " + ScoreC + " on " + ChlName;
        ChlReTxt.text = "Reward: " + Reward + " gems";
        ChlTxtS.text = ChllTxt.text;
        ChlRTxtS.text = ChlReTxt.text;

    }
}
