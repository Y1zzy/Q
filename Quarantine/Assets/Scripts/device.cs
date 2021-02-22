using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class device : MonoBehaviour
{
    public GameObject phone;
    public GameObject chatOn;
    public GameObject chatOff;
    public GameObject message;
    public GameObject apps;
    public bool deviceOn;
    public GameObject newsOn;
    public GameObject newsOff;
    public GameObject newsPage;
    public bool newsIsOn;
    public bool chatIsOn;
    // Start is called before the first frame update
    void Start()
    {
        deviceOn = false;
        chatIsOn = false;
        apps.SetActive(false);
        newsIsOn = false;
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
        }
        else
        {
            apps.SetActive(false);
        }
    
       


    }

    void chat()
    {
        newsIsOn = false;
        newsOff.SetActive(true);
        newsOn.SetActive(false);
        newsIsOn = true;
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
}
