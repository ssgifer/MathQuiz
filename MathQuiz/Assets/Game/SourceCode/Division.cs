using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Division : MonoBehaviour
{
    // Start is called before the first frame update
    private int x, y;
    private int answer;
    public Text valueX, valueY;

    void Start()
    {
        DivisionMethod();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DivisionMethod()
    {
        x = Random.Range(0, 99);
        y = Random.Range(0, 99);
        valueX.text = "" + x;
        valueY.text = "" + y;
    }
}
