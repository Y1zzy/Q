using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day1Progress : MonoBehaviour
{
    public timer timeManager;
    //public Text timeText;
    //public Text calendar;
    //public int initialhr = 11, initialmin = 37;
    public laptop laptoptasks;
    
    // Start is called before the first frame update
    void Start()
    {
        //calendar.text = "Mar.9th 2020";
    }

    // Update is called once per frame
    void Update()
    {
        // a check of status and general progress
        if (timeManager.hoursworked >= 10)
        {
            laptoptasks.abletowork = false;
            
        }
        else
        {
            laptoptasks.abletowork = true;
            
        }
        //timeManager.hour 
        //at 12:00am
        //start being dizzy

        //Man, it feels empty.
        //should I let loose a bit?
        //What else have I missed today?
    }
}
