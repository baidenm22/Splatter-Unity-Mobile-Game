using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public GameObject OnScreen;

    public GameObject EndScreen;
    public GameObject Triagnle;
    public Text score;
    public GameObject scoreText;

    public GameObject GameManager;

    public float targetSize;

    public float increaseInt;


    public GameObject Buttonone;
    public bool restartScene = false;
    public float buttonSize = 1;
    public float increaseIntButton;


    public bool goMM = false;
    public GameObject buttonTwo;
    public float buttonTwoSize;
    public float increaseIntButtonTwo;


    

    public GameObject HiScoreText;
    public Text HiScore;
    public GameObject gem;

    public int Gamemode;
    public GameObject SceneTrans;

    public GameObject Endbutton1;
    public GameObject Endbutton2;

    public GameObject CCTXT;
    public Sprite circleplain;

    public GameObject CTXT;

    // Start is called before the first frame update
    void Start()
    {
        //Get GameMode
        Gamemode = PlayerPrefs.GetInt("GameMode", 1);


        buttonTwoSize = buttonTwo.transform.localScale.x;
        buttonSize = Buttonone.transform.localScale.x;
        targetSize = GameManager.GetComponent<TargetLocation>().targetOnScreen.transform.localScale.x;
    }
    void Update()
    {
     



        //Start the restart transition
        if (restartScene == true && buttonSize < 23)
        {
            //Increase and animate button growth
            buttonSize += Time.deltaTime * increaseIntButton;
            Buttonone.transform.localScale = new Vector3(buttonSize, buttonSize, 1);

        } else if (buttonSize != 1)
        {
            //Load new scene
            SceneManager.LoadScene(Gamemode + 1);
        }

        //Death Actaivation
        if (targetSize < 2.6)
        {
            //Change Sprite
            GameManager.GetComponent<TargetLocation>().targetOnScreen.GetComponent<SpriteRenderer>().sprite = circleplain;
            GameManager.GetComponent<TargetLocation>().targetOnScreen.GetComponent<StyleApply>().enabled = false;
            //Enable Menu
            EndScreen.SetActive(true);
            //Remove OnScreen Stuff
            OnScreen.SetActive(false);
            //Grow Target Size var
            targetSize += Time.deltaTime * increaseInt;
            //Disable collider
            
            GameManager.GetComponent<TargetLocation>().targetOnScreen.GetComponent<Collider2D>().enabled = false;
         

            //Grow
            GameManager.GetComponent<TargetLocation>().targetOnScreen.transform.localScale = new Vector3(targetSize, targetSize, 1);
            
        } else
        {
            //Add the text
            scoreText.SetActive(true);
            score.text = "SCORE: " + GameManager.GetComponent<Touch>().Points.ToString();
            HiScoreText.SetActive(true);
            HiScore.text = ("HIGHSCORE: " + GameManager.GetComponent<SaveData>().HighScore.ToString());
            gem.SetActive(true);
            Endbutton1.GetComponent<Button>().interactable = true;
            Endbutton2.GetComponent<Button>().interactable = true;
            CCTXT.SetActive(true);
            CTXT.SetActive(true);
        }

    }

    public void MainMenu()
    {

        //goMM = true;
        // SceneManager.LoadScene(0);

        SceneTrans.GetComponent<Transition>().makeSplatVis(true);
        SceneTrans.GetComponent<Transition>().loadLevel(0);


    }
    public void RestartScene()
    {
        restartScene = true;
       // SceneManager.LoadScene(1);


    }
    
}
