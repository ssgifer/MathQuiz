using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void link()
    {
        Application.LoadLevel("1");
    } 

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
