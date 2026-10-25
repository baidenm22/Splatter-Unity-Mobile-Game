using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class StyleApply : MonoBehaviour
{

    public int appliedskinnum = 0;
    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;
    public Sprite ten;
    // Start is called before the first frame update
    void Start()
    {
        appliedskinnum = PlayerPrefs.GetInt("Skin", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(appliedskinnum == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = zero;
        }
        if (appliedskinnum == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = one;
        }
        if (appliedskinnum == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = two;
        }
        if (appliedskinnum == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = three;
        }
        if (appliedskinnum == 4)
        {
            this.GetComponent<SpriteRenderer>().sprite = four;
        }
        if (appliedskinnum == 5)
        {
            this.GetComponent<SpriteRenderer>().sprite = five;
        }
        if (appliedskinnum == 6)
        {
            this.GetComponent<SpriteRenderer>().sprite = six;
        }
        if (appliedskinnum == 7)
        {
            this.GetComponent<SpriteRenderer>().sprite = seven;
        }
        if (appliedskinnum == 8)
        {
            this.GetComponent<SpriteRenderer>().sprite = eight;
        }
        if (appliedskinnum == 9)
        {
            this.GetComponent<SpriteRenderer>().sprite = nine;

        }
        if (appliedskinnum == 10)
        {
            this.GetComponent<SpriteRenderer>().sprite = ten;
        }

    }
}
