using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemCount : MonoBehaviour
{

    public Text text;
    public int GEM;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Get Gem Count
        GEM = PlayerPrefs.GetInt("Gem", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Get Gem Count
        GEM = PlayerPrefs.GetInt("Gem", 0);
        //Set Text to gem count
        text.text = GEM.ToString();


    }
}
