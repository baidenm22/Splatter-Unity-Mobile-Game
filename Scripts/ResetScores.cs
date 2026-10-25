using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("HighScore5", 0);

        PlayerPrefs.SetInt("HighScore", 36);


    }

    
}
