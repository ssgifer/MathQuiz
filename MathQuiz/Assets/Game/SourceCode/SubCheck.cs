using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class SubCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Subtraction.equation.score < 0)
        {
            Application.LoadLevel("Home");
        }
    }

    public void checkTagButton()
    {
        if (gameObject.CompareTag(Subtraction.equation.tagbtn))
        {
            Subtraction.equation.score++;              //บวกคะแนน
            Subtraction.equation.SubtractionMethod();     //โจทย์ใหม่
            TimeBar.equation.currentTime = 1;
            /*Debug.Log(Addition.equation.score);*/
        }
        else
        {
            Subtraction.equation.score--;              //ลบคะแนน
            Subtraction.equation.SubtractionMethod();  //โจทย์ใหม่
            TimeBar.equation.currentTime = 1;
            /*Debug.Log(Addition.equation.score);*/
        }
    }


}
