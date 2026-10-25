using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplatColor : MonoBehaviour
{
    public GameObject self;
    public SpriteRenderer Sprite;
    public int gamemode;

    public float timer;

    void Start()
    {
        gamemode = PlayerPrefs.GetInt("GameMode", 1);

        if (gamemode == 1)
        {
            Sprite.color = new Color(241 / 255f, 44 / 255f, 48 / 255f);

        }
        if (gamemode == 2)
        {
            Sprite.color = new Color(241 / 255f, 44 / 255f, 184 / 255f);

        }
        if (gamemode == 3)
        {
            Sprite.color = new Color(0 / 255f, 214 / 255f, 168 / 255f);

        }
        if (gamemode == 4)
        {
            Sprite.color = new Color(255 / 255f, 134 / 255f, 0 / 255f);

        }
        if (gamemode == 5)
        {
            Sprite.color = new Color(174 / 255f, 235 / 255f, 255 / 255f);

        }
        float scale = Random.Range(0.3f, 0.6f);
        self.GetComponent<Transform>().rotation = Quaternion.AngleAxis(Random.Range(0, 360), Vector3.forward);
        self.GetComponent<Transform>().localScale = new Vector3(scale, scale, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= .1f)
        {
            Destroy(gameObject);
        }
        if (timer > .1f)
        {
            Color color = Sprite.color;
            timer -= Time.deltaTime;
            color.a = color.a - Time.deltaTime / timer;
            Sprite.color = color;
        }
       
        
    }
}
