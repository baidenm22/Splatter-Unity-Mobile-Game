using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocation : MonoBehaviour
{
    public Vector3 pos;
    public float randX;
    public float randY;

    public GameObject target;
    public GameObject coinTarget;

    public GameObject targetOnScreen;
    public GameObject[] moreTargets;

    public bool SpawnNew = false;
    public float typeChance;

    public GameObject WhichTarget;

    private int gamemode;
    public GameObject gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        gamemode = PlayerPrefs.GetInt("GameMode", 1);

      



    }

    // Update is called once per frame
    void Update()
    {

        

    //Ready to spawn new
     if(SpawnNew == true && gamemode != 5)
        {
            SpawnNew = false;
            //What type of taget
            typeChance = Mathf.Round(Random.Range(1, 11));

            if (typeChance == 10)
            {
                WhichTarget = coinTarget;

            }
            else
            {
                WhichTarget = target;
            }

            //Spawn Target
            RandomCoords();
            targetOnScreen = Instantiate(WhichTarget, pos,target.transform.rotation);
           
        }
     if (SpawnNew == true && gamemode == 5)
        {
            int max = 5;
            if(gamemanager.GetComponent<Touch>().Points > 50)
            {
                max = 6;
            }
            if (gamemanager.GetComponent<Touch>().Points > 100)
            {
                max = 7;
            }


            int numberOfTargets = Mathf.RoundToInt(Random.Range(1, max));
            moreTargets = new GameObject[numberOfTargets];
            //Start a multi Target
            for (int i = 0; i < numberOfTargets; i++)
            {
                
                //What type of taget
                typeChance = Mathf.Round(Random.Range(1, 11));
                
                if (typeChance == 10)
                {
                    WhichTarget = coinTarget;

                }
                else
                {
                    WhichTarget = target;
                }

                //Spawn Target
                RandomCoords();
                moreTargets[i] = Instantiate(WhichTarget, pos, target.transform.rotation);
                if (WhichTarget == coinTarget)
                {
                    coinTarget.GetComponent<Collider2D>().enabled = false;
                }
            }
            
            targetOnScreen = Instantiate(WhichTarget, pos, target.transform.rotation);
            targetOnScreen.GetComponent<Collider2D>().enabled = false;
            targetOnScreen.GetComponent<SpriteRenderer>().enabled = false;
                  
            SpawnNew = false;
        }


    }
    void RandomCoords()
    {
        if (gamemode == 3)
        {
            randX = Random.Range(-2f, 2f);
            randY = Random.Range(-3.55f, 3.55f);

        }
        else
        { 
            //Make random Target location
            randX = Random.Range(-2.6f, 2.6f);
            randY = Random.Range(-4.8f, 4.8f);
        }
        pos = new Vector3(randX, randY, 0);
    }
}
