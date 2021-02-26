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
    public bed rest;
    public int chapter;
   
    
    // Start is called before the first frame update
    void Start()
    {
        month = "Mar";
        date = 9;
        chapter = 1;
        calendar.text = string.Format(month + " . " +  date + "th"  + " 2020");
        //dateTracking();
    }

    // Update is called once per frame
    void Update()
    {
        //general statement
        // a check of status and general progress
        workStatus();
        restStatus();
        

        if (timeManager.hour == 12)
        {
            convo.convoNum = 1;
        }
        
    }

    void workStatus()
    {
        if (timeManager.hoursworked >= 10)
        { laptoptasks.abletowork = false; }
        else
        { laptoptasks.abletowork = true; }
    }

    void restStatus()
    {
        if (timeManager.hoursrested >= 2 || timeManager.hoursworked <=4)
        {
            rest.sleepOrNot = false;
        }
        else
        {
            rest.sleepOrNot = true;
        }
    }

    void mandatoryConvo(int convoNumber, int beginninghr, int endhr)
    {
        if(timeManager.hour >=beginninghr || timeManager.hour <= endhr)
        {
            convo.convoNum = convoNumber;
        }
    }
    public void dateTracking()// call when time changes!!!!
    {
        switch (chapter)
        {
            case 1:
                //mandatoryConvo(1, 11, 12);
                //mandatoryConvo()
                
                break;
            case 2:
                
                break;
            case 3:
                
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
        }
    }
}
