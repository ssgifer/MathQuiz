using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtraction : MonoBehaviour
{
    // Start is called before the first frame update
    private int x, y;
    private int answer;
    public Text valueX, valueY;

    void Start()
    {
        AdditionMethod();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AdditionMethod()
    {
        x = Random.Range(0, 99);
        y = Random.Range(0, 99);
        valueX.text = "" + x;
        valueY.text = "" + y;
    }
}
