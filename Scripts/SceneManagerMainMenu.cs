using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerMainMenu : MonoBehaviour
{

    public int gameMode;

    public GameObject Button;
    public bool increaseButtonSize = false;
    public float size = 1;
    public float sizeIn;
    public GameObject sound;

    private void Start()
    {
       
        
    }



    void Update()
    {
        //Get GameMode
        gameMode = PlayerPrefs.GetInt("GameMode", 1);
        //Increase Button
        if (increaseButtonSize == true && size < 13)
        {
            
            size += Time.deltaTime * sizeIn;
            Button.transform.localScale = new Vector3(size, size, 1);
            sound.GetComponent<SoundStart>().decay = true;

        } else if(size != 1)
        {
            //Load Game Based on GameMode
           SceneManager.LoadScene(gameMode + 1);

        }


    
    }





    public void gameScene()
    {
        
            increaseButtonSize = true;
        
       // SceneManager.LoadScene(1);


    }

    public void quit()
    {

        Application.Quit();


    }


}
