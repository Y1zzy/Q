using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day1Progress : MonoBehaviour
{
    public timer timeManager;
    public Text timeText;
    public Text calendar;
    public Wechat convo;
    public string month;
    public int date;
    public int initialhr = 11, initialmin = 37;
    public laptop laptoptasks;
    public int chapter;
    //public bool mandatorychat;
    
    // Start is called before the first frame update
    void Start()
    {
        month = "Mar";
        date = 9;
        chapter = 1;
        calendar.text = string.Format(month + " . " +  date + "th"  + " 2020");
        //mandatorychat = true;
        //calendar.text = "Mar.9th 2020";
    }

    // Update is called once per frame
    void Update()
    {
        //general statement
        // a check of status and general progress
        if (timeManager.hoursworked >= 10)
        {laptoptasks.abletowork = false;}
        else
        { laptoptasks.abletowork = true; }
        
        if (timeManager.hoursrested >= 2)
        {

        }
        
        //timeManager.hour 
        //at 12:00am
        //start being dizzy

        //Man, it feels empty.
        //should I let loose a bit?
        //What else have I missed today?
    }
}
