using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public AudioClip splatter1;
    public AudioClip splatter2;
    public AudioClip splatter3;
    public AudioSource Soundeffect;

    public bool test;
   

    // Update is called once per frame
    void Update()
    {
        if(test == true)
        {
            playRandomSound();
            test = false;
        }
        Soundeffect.volume = PlayerPrefs.GetInt("Sound", 1);
    }
    void playRandomSound()
    {
        int value = Mathf.RoundToInt(Random.Range(.5f, 3.49f));
        if (value == 1)
        {
            Soundeffect.clip = splatter1;
        }
        if (value == 2)
        {
            Soundeffect.clip = splatter2;
        }
        if (value == 3)
        {
            Soundeffect.clip = splatter3;
        }
        Soundeffect.Play();
    }
}
