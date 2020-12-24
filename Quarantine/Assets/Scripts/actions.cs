using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class actions : MonoBehaviour
{
    public string whatISee;
    public Animator doorAnim;
    public Animator bedroomDoorAnim;
    public raycasting raycastobj;
    private bool doorIsOpen;
    private bool door2IsOpen;
    public bool onBed;
    private string interactableObj;
    public GameObject laptopScene;
    public player onBedStatus;
    public GameObject phoneScreen;
    public GameObject wechatOn, wechatOff, discordOn, discordOff, plannerOn, plannerOff;
    public bool wechatting,discording,planner;
    public GameObject timeManager;
    void start()
    {
     
        onBed = false;
        wechatting = false;
        discording = false;
        planner = false;
    }

    
    void Update()
    {
        whatISee = raycastobj.InteractText; //access the object info from raycasting
       // Debug.Log(whatISee);
        if (whatISee == "door")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                openTheDoor();
            }  
        }
        if (whatISee == "bdoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                open2Door();
            }
        }

        if (whatISee == "Laptop")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                laptoptask();
            }
        }
        

        if (whatISee == "bed")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                onBedStatus.isOnBed = true;
                goToBed();
            }
        }

        if (onBed) //this condition decides if the player will get on the bed or get off the bed
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                onBedStatus.isOnBed = false;
                goToBed();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))//this condition opens up the wechat panel
        {
            discordOn.SetActive(false);
            discordOff.SetActive(true);
            discording = false;
            plannerOn.SetActive(false);
            plannerOff.SetActive(true);
            planner = false;
            wechat();
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))//this condition opens up the wechat panel
        {
            wechatOn.SetActive(false);
            wechatOff.SetActive(true);
            wechatting = false;
            plannerOn.SetActive(false);
            plannerOff.SetActive(true);
            planner = false;
            discord();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))//this condition opens up the wechat panel
        {
            wechatOn.SetActive(false);
            wechatOff.SetActive(true);
            wechatting = false;
            discordOn.SetActive(false);
            discordOff.SetActive(true);
            discording = false;
            openplanner();
        }
    }

    void openTheDoor() // this function is to open the bathroom door
    {

        if (doorIsOpen == true)
        {
            doorAnim.SetBool("open", false);
            doorIsOpen = false;
        }
        else
        {
            doorAnim.SetBool("open", true);
            doorIsOpen = true;
        }
    }
    void open2Door() //this function is to open the bedroom door
    {

        if (door2IsOpen == true)
        {
            bedroomDoorAnim.SetBool("open", false);
            door2IsOpen = false;
        }

        else
        {
            
            bedroomDoorAnim.SetBool("open", true);
            door2IsOpen = true;
        }
    }
    void goToBed()
    {
        if (onBed == false)
        {
            transform.position = new Vector3(-10, 7.42f, -4);
            //transform.rotation = new Quaternion(45,0,0,0);
            onBed = true;
        }
        else
        {
            transform.position = new Vector3(-5, 7.42f, -4);
            onBed = false;
        }
    }

    void laptoptask()
    {

    }
    

    void wechat()
    {
        if (!wechatting)
        {
            
            wechatOn.SetActive(true);
            wechatOff.SetActive(false);
            wechatting = true;

        }
        else
        {
            wechatOn.SetActive(false);
            wechatOff.SetActive(true);
            wechatting = false;
        }
    }
    void discord()
    {
        if (!discording)
        {

            discordOn.SetActive(true);
            discordOff.SetActive(false);
            discording = true;

        }
        else
        {
            discordOn.SetActive(false);
            discordOff.SetActive(true);
            discording = false;
        }
    }
    void openplanner()
    {
        if (!planner)
        {

            plannerOn.SetActive(true);
            plannerOff.SetActive(false);
            planner = true;

        }
        else
        {
            plannerOn.SetActive(false);
            plannerOff.SetActive(true);
            planner = false;
        }
    }
}
