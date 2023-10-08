using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class MulCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Multiplication.equation.score < 0)
        {
            Application.LoadLevel("Home");
        }
    }

    public void checkTagButton()
    {
        if (gameObject.CompareTag(Multiplication.equation.tagbtn))
        {
            Multiplication.equation.score++;              //บวกคะแนน
            Multiplication.equation.MultiplicationMethod();     //โจทย์ใหม่
            TimeBar.equation.currentTime = 1;
            /*Debug.Log(Addition.equation.score);*/
        }
        else
        {
            Multiplication.equation.score--;              //ลบคะแนน
            Multiplication.equation.MultiplicationMethod();     //โจทย์ใหม่
            TimeBar.equation.currentTime = 1;
            /*Debug.Log(Addition.equation.score);*/
        }
    }


}
