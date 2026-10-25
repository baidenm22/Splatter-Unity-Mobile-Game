using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ButtonDown : MonoBehaviour
{
    public bool R;
    public bool L;


    public void StartAnimation()
    {
        if (R == true)
        {
            this.GetComponent<Animator>().SetTrigger("Down");
        } else if (L == true)
        {
            this.GetComponent<Animator>().SetTrigger("DownL");
        }
    }
    

    
}
