using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testCode : MonoBehaviour
{

    private float x, y;
    private float answer;
    public Text ValueX, ValueY;
    // Start is called before the first frame update
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
        x = Random.Range(0,99);
        y = Random.Range(0,99);
        ValueX.text = "" + x;
        ValueY.text = "" + y;
        answer = x + y;
        Debug.Log(answer);
    }
}
