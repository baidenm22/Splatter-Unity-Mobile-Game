using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public int screenColor = 1;
    public GameObject BackGround;
    public GameObject GameManager;
    public GameObject GemObject;
    public Sprite PlainCircle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetComponent<Timer>().countDown <= 1.5f)
        {
            screenColor = 2;
            for (int i = 0; i < GameManager.GetComponent<TargetLocation>().moreTargets.Length; i++)
            {
                
                if (GameManager.GetComponent<TargetLocation>().moreTargets[i] != null)
                {
                    GameManager.GetComponent<TargetLocation>().moreTargets[i].GetComponent<StyleApply>().enabled = false;
                    GameManager.GetComponent<TargetLocation>().moreTargets[i].GetComponent<SpriteRenderer>().sprite = PlainCircle;
                    GameManager.GetComponent<TargetLocation>().moreTargets[i].GetComponent<Collider2D>().enabled = true;
                    if (GameManager.GetComponent<TargetLocation>().moreTargets[i].name == "Coin Target(Clone)")
                    {
                        GameManager.GetComponent<TargetLocation>().moreTargets[i].GetComponent<StyleApply>().enabled = false;
                        GameManager.GetComponent<TargetLocation>().moreTargets[i].GetComponent<SpriteRenderer>().sprite = PlainCircle;
                        GameManager.GetComponent<TargetLocation>().moreTargets[i].GetComponent<SpriteRenderer>().color = new Color(174 / 255f, 235 / 255f, 255 / 255f);
                    }
                }
            }
        }
        if (GameManager.GetComponent<Timer>().countDown <= 0)
        {
            screenColor = 1;
            GameManager.GetComponent<TargetLocation>().targetOnScreen.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (GameManager.GetComponent<Timer>().countDown >= 1.5f)
        {
            screenColor = 1;
            
        }

        if (screenColor == 1)
        {
            BackGround.GetComponent<SpriteRenderer>().color = new Color(255 / 255f, 255/ 255f, 255/ 255f);
        }
        if (screenColor == 2)
        {
            BackGround.GetComponent<SpriteRenderer>().color = new Color(174 / 255f, 235 / 255f, 255 / 255f);
        }




    }
}
