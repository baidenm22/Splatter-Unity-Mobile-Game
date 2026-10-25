using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDes : MonoBehaviour
{

    public float Timer;

    private float x;
    private float y;
    

    // Update is called once per frame
    void Update()
    {

        Timer -= Time.deltaTime;

        if(gameObject.transform.localScale.x - Time.deltaTime * .2f > 0)
        {
            x = gameObject.transform.localScale.x - Time.deltaTime * .2f;
        }
        if (gameObject.transform.localScale.y - Time.deltaTime * .2f > 0)
        {
            y = gameObject.transform.localScale.x - Time.deltaTime * .2f;
        }

        gameObject.transform.localScale = new Vector3(x,y, 1);

        if (Timer < 0)
        {
            Destroy(gameObject);

        }




    }
}
