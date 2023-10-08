using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    public Transform filbar;
    public float currentTime;
    public float delay = 0.5f;
    public static TimeBar equation;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 1;
    }

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

    // Update is called once per frame
    void Update()
    {
        currentTime -= delay * Time.deltaTime;
        filbar.GetComponent<Image>().fillAmount = currentTime;

        if(currentTime < 0.1f)
        {
            Application.LoadLevel("Home");
        }
    }
}
