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
    public GameObject taskDate;
    public GameObject task;
    public GameObject task2;
    public GameObject task3;
    public GameObject task4;
    public GameObject chatname;
    public stove meal;
    public book book;
    
    string cN;
    bool dayGoingOn;
    int sleepTime;
    public fade fading;
    public GameObject panel;
    //int convoNumber;

    string innerworldtext;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(true);
        fading.FadeOut();
        chapter = 1;
        //cN = chatname.GetComponent<Text>().text;
        dateTracking();
    }

    // Update is called once per frame
    void Update()
    {
        dateTracking();
        //general statement
        // a check of status and general progress
        workStatus();
        mustSleep();
        restStatus();
        hungerStatus();
        readStatus();
        //Debug.Log(timeManager.hour);
        
        if(chapter == 1)
        {
           
            convoTracking();
        }


        
        
    }

    

    void hungerStatus()
    {
        if (timeManager.hour == 12 || timeManager.hour ==18)
        {
            meal.hungry = true;
        }
       
        else
        { meal.hungry = false; }
    }

    void workStatus()
    {
        if (timeManager.hoursworked >= 10)
        { laptoptasks.abletowork = false; }
        else
        { laptoptasks.abletowork = true; }
    }

    void readStatus()
    {
        if (timeManager.hoursread >= 2)
        { book.readable = false; }
        else
        { book.readable = true; }
    }

    void restStatus()
    {
        
        if (timeManager.hoursrested >= 2 || timeManager.hoursworked <=4)
        {
            if (sleepTime - timeManager.hour <= 3)
            {
                rest.sleepOrNot = false;
            }
        }

        else
        {
            rest.sleepOrNot = true;
        }
    }

    void mustSleep()
    {
        if(timeManager.hour > (sleepTime - 1) && timeManager.hour < (sleepTime + 5))
        {
            
            //set this into sleep
            rest.sleepOrNot = true;
            if (timeManager.hour >= (sleepTime + 1) && timeManager.hour < (sleepTime + 4))
            {
                fading.FadeIn();
                chapter += 1;
                clearout();
            }
        }
    }

    void clearout()
    {
        timeManager.hoursrested = 0;
        timeManager.hoursworked = 0;
        timeManager.hoursread = 0;
    }

    void mandatoryConvo(int convoNumber, int beginninghr, int endhr)
    {
       
        //Debug.Log(convo.convoNum);
        if (timeManager.hour >= beginninghr && timeManager.hour <= endhr)
        {
           
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
                cN = "Ball is life";
                chatname.GetComponent<Text>().text = cN;
                break;
            case 1:
                cN = "Mother";
                chatname.GetComponent<Text>().text = cN;
                mandatoryConvo(1, 12, 13);
                break;
            case 2:
                cN = "James H.";
                chatname.GetComponent<Text>().text = cN;
                mandatoryConvo(2, 14, 15);
                break;
            case 3:
                cN = "Yi N.";
                chatname.GetComponent<Text>().text = cN;
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
                sleepTime = 1;
                //timeManager.initialhr = 11;
                //timeManager.initialmin = 37;
                
                taskDate.GetComponent<Text>().text = "03-07";
                task.GetComponent<Text>().text = "Animation Project";
                task2.GetComponent<Text>().text = "...";
                task3.SetActive(false);
                task4.SetActive(false);
                break;
            case 2:
                month = "Mar";
                date = 8;
                sleepTime = 1;
                timeManager.initialhr = 10;
                timeManager.initialmin = 25;
                taskDate.GetComponent<Text>().text = "03-08";
                task.GetComponent<Text>().text = "Animation Project";
                task2.GetComponent<Text>().text = "Game Project";
                task3.SetActive(false);
                task4.SetActive(false);
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
