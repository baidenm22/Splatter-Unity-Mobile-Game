using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTor : MonoBehaviour
{

    public float timer;
    private Vector3 touchPos;
    private Vector3 touchWorld;
    public bool grow = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("FTTF", 1);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer > 0)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector2(gameObject.GetComponent<Transform>().localScale.x - (Time.deltaTime * .05f), gameObject.GetComponent<Transform>().localScale.y - (Time.deltaTime * .05f));
        }

        if (timer < 0 && timer != -1000)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector2((gameObject.GetComponent<Transform>().localScale.x + (Time.deltaTime * .05f)), (gameObject.GetComponent<Transform>().localScale.y + (Time.deltaTime * .05f)));
           
        }
        if (timer < -1 && timer != -1000)
        {
            timer = 1;
        }

        if (Input.touchCount > 0)
        {
            touchPos = Input.GetTouch(0).position;
        }
        touchWorld = Camera.main.ScreenToWorldPoint(touchPos);

        RaycastHit2D hit = Physics2D.Raycast(touchWorld, new Vector2(touchWorld.x + 0.01f, touchWorld.y + .01f));
        if (hit.collider != null)
        {
            grow = true;
        }

        if (grow == true)
        {
            timer = -1000;
            gameObject.GetComponent<Transform>().localScale = new Vector2(gameObject.GetComponent<Transform>().localScale.x + (Time.deltaTime * .4f), gameObject.GetComponent<Transform>().localScale.y + (Time.deltaTime * .4f));
        }
        if (gameObject.GetComponent<Transform>().localScale.x >= 1.4f)
        {
            SceneManager.LoadScene(0);
        }

    }
}
