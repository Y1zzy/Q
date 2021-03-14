using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class device : MonoBehaviour
{
    public GameObject phone;
    public GameObject lockscreen;
    public GameObject chatOn;
    public GameObject chatOff;
    public GameObject message;
    //public GameObject plannerPage;
    public GameObject apps;
    public bool deviceOn;
    public GameObject newsOn;
    public GameObject newsOff;
    public GameObject newsPage;
    public GameObject plannerOn;
    public GameObject plannerOff;
    public GameObject plannerPage;
    public bool newsIsOn;
    public bool chatIsOn;
    public bool plannerIsOn;
    // Start is called before the first frame update
    void Start()
    {
        deviceOn = false;
        chatIsOn = false;
        plannerIsOn = false;
        apps.SetActive(false);
        newsIsOn = false;
        plannerPage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (deviceOn)
        {
            apps.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                chat();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                news();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                planner();
            }
        }
        else
        {
            apps.SetActive(false);
        }
    
       


    }

    void chat() //1
    {
        newsIsOn = false;
        plannerIsOn = false;
        newsOff.SetActive(true);
        newsOn.SetActive(false);
        plannerOff.SetActive(true);
        plannerOn.SetActive(false);
        newsIsOn = true;
        plannerPage.SetActive(false);
        lockscreen.SetActive(false);
        if (chatIsOn == false)
        {
            chatOff.SetActive(true);
            //newsIsOn = false;
            chatOn.SetActive(false);
            message.SetActive(false);
            chatIsOn = true;
        }
        if (chatIsOn == true)
        {
            chatOff.SetActive(false);
            chatOn.SetActive(true);
            message.SetActive(true);
            chatIsOn = false;
        }
    }
    void news() 
    {
        chatOff.SetActive(true);
        chatOn.SetActive(false);
        message.SetActive(false);
        chatIsOn = false;
        plannerIsOn = false;
        plannerOff.SetActive(true);
        plannerOn.SetActive(false);
        plannerPage.SetActive(false);
        lockscreen.SetActive(false);
        if (newsIsOn == false)
        {
            newsOff.SetActive(true);
            
            newsOn.SetActive(false);
            //message.SetActive(false);
            newsIsOn = true;
        }
        if (newsIsOn == true)
        {
            newsOff.SetActive(false);
            newsOn.SetActive(true);
            //message.SetActive(true);
            newsIsOn = false;
        }
    }

    void planner()
    {
        newsIsOn = false;
        chatIsOn = false;
        newsOff.SetActive(true);
        newsOn.SetActive(false);
        chatOff.SetActive(true);
        chatOn.SetActive(false);
        message.SetActive(false);
        lockscreen.SetActive(false);
        //newsIsOn = true;
        if (plannerIsOn == false)
        {
            plannerOff.SetActive(true);
          
            plannerOn.SetActive(false);
            plannerPage.SetActive(false);
            plannerIsOn = true;
        }
        if (plannerIsOn == true)
        {
            plannerOff.SetActive(false);
            plannerOn.SetActive(true);
            plannerPage.SetActive(true);
            plannerIsOn = false;
        }
    }
}
