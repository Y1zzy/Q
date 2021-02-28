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
    public GameObject agenda;
    public int chapter;
    bool dayGoingOn;
    //int convoNumber;

    string innerworldtext;

    // Start is called before the first frame update
    void Start()
    {
        
        chapter = 1;
        //calendar.text = string.Format(month + " . " +  date + "th"  + " 2020");
        dateTracking();
    }

    // Update is called once per frame
    void Update()
    {
        
        //general statement
        // a check of status and general progress
        workStatus();
        restStatus();
        //Debug.Log(timeManager.hour);
        
        if(chapter == 1)
        {
           
            convoTracking();
        }


        
        
    }

    void workStatus()
    {
        if (timeManager.hoursworked >= 6)
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
       
        Debug.Log(convo.convoNum);
        if (timeManager.hour >= beginninghr && timeManager.hour <= endhr)
        {
            //Debug.Log("may i come here?");
            convo.convoNum = convoNumber;
        }

        else
        {
            if (convoNumber == convo.convoNum && convo.convoDone == true)
            {
                convo.destroy();
                convo.convoNum += 1;
                Debug.Log("convoNum plused" + convo.convoNum);
            }

            else
            {

            }
            
        }
       
    }

    public void convoTracking()
    {
        switch (convo.convoNum)
        {
            case 0:
                mandatoryConvo(0, 10, 11);
                
                break;
            case 1:
                mandatoryConvo(1, 12, 13);
                break;
            case 2:
                mandatoryConvo(2, 14, 15);
                break;
            case 3:
                mandatoryConvo(3, 16, 17);
                break;
        }
    }

    public void dateTracking()// call when time changes!!!!
    {
        switch (chapter)
        {
            case 1:
                month = "Mar";
                date = 7;
                
                break;
            case 2:
                month = "Mar";
                date = 8;

                break;
            case 3:
                month = "Mar";
                date = 9;

                break;
            case 4:
                month = "Mar";
                date = 11;
                break;
            case 5:
                month = "Mar";
                date = 12;

                break;
            case 6:
                month = "Mar";
                date = 23;

                break;
            case 7:
                month = "Apr";
                date = 10;
                break;
            case 8:
                month = "May";
                date = 5;
                break;
        }
        calendar.text = string.Format(month + " . " + date + "th" + " 2020");
    }
}
