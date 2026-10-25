using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{

    public Animator tran;
    public GameObject Splat;

    // Update is called once per frame
    void Update()
    {
        

    }
    public void makeSplatVis(bool yes)
    {
        if (yes == true)
        {
            Splat.SetActive(true);
        }
    }

    public void loadLevel(int BuildIndex)
    {
        StartCoroutine(startTran(BuildIndex));
    }

    IEnumerator startTran(int buildIndex)
    {

        tran.SetTrigger("Start");

        yield return new WaitForSeconds(1.1f);

        SceneManager.LoadScene(buildIndex);

    }

}
