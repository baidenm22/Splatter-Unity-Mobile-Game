using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStart : MonoBehaviour
{


    private float timer = 0;
    private float timer2 = 0;

    public bool decay = false;

    // Update is called once per frame
    void Update()
    {
        int soundVar = PlayerPrefs.GetInt("Sound", 1);

        if (soundVar == 1)
        {
            if (timer < 1)
            {

                timer += Time.deltaTime;
                this.GetComponent<AudioSource>().volume += .5f * Time.deltaTime;

            }
            if (decay == true)
            {
                timer2 += Time.deltaTime;
                this.GetComponent<AudioSource>().volume -= .5f * Time.deltaTime;
            }
        } else
        {
            this.GetComponent<AudioSource>().volume = 0;
            timer = 0;
            timer2 = 0;
        }
    }
    public void decays()
    {
        decay = true;
    }
}
