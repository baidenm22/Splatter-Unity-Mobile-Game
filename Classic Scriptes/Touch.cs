using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;



public class Touch : MonoBehaviour
{
    public Vector2 TouchPosition;
    public Vector2 TouchWorld;

    public Text text;
    public TargetLocation scriptLoc;
    public Timer scriptTimer;

    public bool releasedFinger = true;

    public int Points = 0;
    public int GEM = 0;

    public GameObject GEMObject;

    public bool allowDrag;

    public int gamemode;
    public GameObject gameManager;

    public GameObject BackGround;
    public GameObject[] paintSplatters;

    public int numberOfHits = 0;

    public bool spawnPaintQ = false;
    public GameObject splat;

    public GameObject[] SplatterSounds;
    private int value;

    public int EXTRALIVES;
    public GameObject MinusLife;

    void Start()
    {
        GEM = PlayerPrefs.GetInt("Gem", 0);
        TouchPosition = new Vector2(2000, 2000);
        gamemode = PlayerPrefs.GetInt("GameMode", 1);
        EXTRALIVES = PlayerPrefs.GetInt("PELvl", 0);
    }



    // Update is called once per frame
    void Update()
    {
        
        text.text = Points.ToString();

        //Get location of tap


        if (Input.touchCount > 0)
        {
            if (releasedFinger == true)
            {
                TouchPosition = Input.GetTouch(0).position;
            }
            if (Input.GetTouch(0).phase == TouchPhase.Began && allowDrag == false)
            {
                releasedFinger = false;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Ended && allowDrag == false)
            {
                releasedFinger = true;
            }
        }





        TouchWorld = Camera.main.ScreenToWorldPoint(TouchPosition);

        //Check location has something there
        RaycastHit2D hit = Physics2D.Raycast(TouchWorld, new Vector2(TouchWorld.x + 0.01f, TouchWorld.y + .01f));



        //Check if you tap something
        if (hit.collider != null)
        {
            //PlaySound
            playRandomSplatterSound();

            //Check if gem Target;
            if (hit.collider.gameObject.name == "Coin Target(Clone)")
            {
                //Spawn Paint

                GEM += 1;
                PlayerPrefs.SetInt("Gem", GEM);
                PlayerPrefs.Save();
                Instantiate(GEMObject, new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, hit.collider.gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));

            }

            //Check if Lights Gamemode
            if (gamemode == 4)
            {
                if (BackGround.GetComponent<BackGroundColor>().color == 1 || BackGround.GetComponent<BackGroundColor>().color == 3)
                {
                    Destroy(hit.transform.gameObject);
                    scriptLoc.SpawnNew = true;
                    scriptTimer.countDown += 1 / 3f;
                    Points += 1;

                }
                else
                {
                    gameManager.GetComponent<ChallenCheck>().GameEnd = true;
                    gameManager.GetComponent<Touch>().enabled = false;
                    gameManager.GetComponent<SaveData>().runScoreCheck = true;
                    gameManager.GetComponent<Restart>().enabled = true;
                    BackGround.GetComponent<BackGroundColor>().enabled = false;
                }

            }
            else if (gamemode == 5)
            {
                Points++;
                numberOfHits++;
                Destroy(hit.transform.gameObject);


                if (numberOfHits == gameManager.GetComponent<TargetLocation>().moreTargets.Length)
                {
                    scriptLoc.SpawnNew = true;
                    scriptTimer.countDown = 2f;
                    numberOfHits = 0;
                }




            }
            else
            {

                //Destroy Target
                Destroy(hit.transform.gameObject);
                scriptLoc.SpawnNew = true;
                scriptTimer.countDown += .1f;
                Points += 1;
            }
            if (gamemode == 3)
            {
                scriptTimer.countDown = .8f;
            }
            //Spawn paint
            spawnPaintQ = true;
            spawnPaint(TouchWorld);
            
        } // Not Hitting Anything
        else if (gamemode == 3)
        {
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began && EXTRALIVES <= 0)
                {

                        gameManager.GetComponent<Touch>().enabled = false;
                        gameManager.GetComponent<SaveData>().runScoreCheck = true;
                        gameManager.GetComponent<Restart>().enabled = true;

                } else if (Input.GetTouch(0).phase == TouchPhase.Began && EXTRALIVES > 0)
                {
                    EXTRALIVES -= 1;
                    MinusLife.GetComponent<Animator>().SetTrigger("Minuslife");
                    gameManager.GetComponent<Timer>().countDown += 1f;
                }
            }
        }

    }
    public void spawnPaint(Vector3 pos)
    {
        if (spawnPaintQ == true)
        {
          
            int vaule = Mathf.RoundToInt(Random.Range(1, 3));
            splat = Instantiate(paintSplatters[vaule], pos, new Quaternion(0, 0, 0, 0));
            spawnPaintQ = false;
            
        }

    }
    public void playRandomSplatterSound()
    {
        if (value == 0)
        {
            value = 1;
        }
        if (value == 1)
        {
            value = 2;
        }
        if (value == 2)
        {
            value = 0;
        }
        SplatterSounds[value].GetComponent<Audio>().test = true;

    }
}
