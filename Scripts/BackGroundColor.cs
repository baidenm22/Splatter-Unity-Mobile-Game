using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundColor : MonoBehaviour
{
    public int color = 1;
    public int gameMode;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        gameMode = PlayerPrefs.GetInt("GameMode", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameMode == 4)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                if (color == 1)
                {
                    color = 3;
                    timer = .5f;
                } else if (color == 2)
                {
                    color = 1;
                    RandomTimer();
                } else if (color == 3)
                {
                    color = 2;
                    timer = 1f;
                }
                
               
            }
            if (color == 2)
            {
                gameObject.GetComponent<SpriteRenderer>().color = new Color(255 / 255f, 66 / 255f, 66 / 255f);
            }
            if (color == 1)
            {
                gameObject.GetComponent<SpriteRenderer>().color = new Color(122 / 255f, 255 / 255f, 187 / 255f);
            }
            if (color == 3)
            {
                gameObject.GetComponent<SpriteRenderer>().color = new Color(255 / 255f, 226 / 255f, 123 / 255f);
            }
        }
        
    }
    void RandomTimer()
    {
        timer = Random.Range(1f, 3f);


    }
}
