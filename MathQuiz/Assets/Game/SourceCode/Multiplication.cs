﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplication : MonoBehaviour
{
    private int x, y;       //x=ตัวตั้ง, y=ตัวคูณ
    private int answer;
    public Text valueX, valueY, ScoreText;
    private float Answer;
    public int score;
    public GameObject[] choicebtn;  //4ช้อย
    public string tagbtn;
    public static Multiplication equation;

    private void Awake()
    {
        MakeEquation();
    }

    void MakeEquation()
    {
        if (equation == null)
        {
            equation = this;
        }
    }

    private void Start()
    {
        MultiplicationMethod();
    }

    // Update is called once per frame
    void Update()
    {
        tagbtn = Answer.ToString();
        ScoreText.text = "" + score;
    }

    public void MultiplicationMethod()
    {
        x = Random.Range(0, 25);    //1-25
        y = Random.Range(0, 25);    //1-25
        valueX.text = "" + x;
        valueY.text = "" + y;
        answer = x * y;             //ค่าx+y

        //choice คำตอบที่ถูก
        Answer = Random.Range(0, choicebtn.Length);

        //loop choice คำตอบ
        for (int i = 0; i < choicebtn.Length; i++)
        {
            //check คำตอบให้ตรงกับ localofAnswer
            if (i == Answer)
            {
                choicebtn[i].GetComponentInChildren<Text>().text = "" + answer;     //คำตอบที่ถูก
            }
            //คำตอบที่ผิด
            else
            {
                choicebtn[i].GetComponentInChildren<Text>().text = "" + Random.Range(1, 100);
                while (choicebtn[i].GetComponentInChildren<Text>().text == "" + answer)
                {
                    choicebtn[i].GetComponentInChildren<Text>().text = "" + Random.Range(1, 100);
                }
            }
        }
    }
}
