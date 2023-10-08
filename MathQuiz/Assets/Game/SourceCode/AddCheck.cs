using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class AddCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Addition.equation.score < 0)
        {
            Application.LoadLevel("Home");
        }
    }

    public void checkTagButton()
    {
        if (gameObject.CompareTag(Addition.equation.tagbtn))
        {
            Addition.equation.score++;              //บวกคะแนน
            Addition.equation.AdditionMethod();     //โจทย์ใหม่
            TimeBar.equation.currentTime = 1;
            /*Debug.Log(Addition.equation.score);*/
        }
        else
        {
            Addition.equation.score--;              //ลบคะแนน
            Addition.equation.AdditionMethod();     //โจทย์ใหม่
            TimeBar.equation.currentTime = 1;
            /*Debug.Log(Addition.equation.score);*/
        }
    }


}
