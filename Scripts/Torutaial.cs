using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Torutaial : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("FTTF", 0) != 1)
        {
            SceneManager.LoadScene(1);
        }
    }
}
