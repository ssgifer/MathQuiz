using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class DivCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Division.equation.score < 0)
        {
            Application.LoadLevel("Home");
        }
    }

    public void checkTagButton()
    {
        if (gameObject.CompareTag(Division.equation.tagbtn))
        {
            Division.equation.score++;              //บวกคะแนน
            Division.equation.DivisionMethod();     //โจทย์ใหม่
            TimeBar.equation.currentTime = 1;
            /*Debug.Log(Addition.equation.score);*/
        }
        else
        {
            Division.equation.score--;              //ลบคะแนน
            Division.equation.DivisionMethod();     //โจทย์ใหม่
            TimeBar.equation.currentTime = 1;
            /*Debug.Log(Addition.equation.score);*/
        }
    }


}
