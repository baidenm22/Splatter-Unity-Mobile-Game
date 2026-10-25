using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Factor;
    public int number;
    private void Start()
    {
        number = Mathf.RoundToInt(Random.Range(-2, 1));
        if (number == 0)
        {
            number = 1;
        }
        Factor = Random.Range(15, 180);
    }
    // Update is called once per frame
    void Update()
    {
        
        this.GetComponent<Transform>().Rotate(new Vector3(0, 0, (number * Factor * Time.deltaTime)));
    }
}
