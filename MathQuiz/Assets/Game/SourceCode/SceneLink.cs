using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLink : MonoBehaviour
{
    // Start is called before the first frame update
    public void Home() => Application.LoadLevel("Menu");
    public void Add() => Application.LoadLevel("AddQuiz");
    public void Sub() => Application.LoadLevel("SubQuiz"); 
    public void Mul() => Application.LoadLevel("MulQuiz");
    public void Div() => Application.LoadLevel("DivQuiz");
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
