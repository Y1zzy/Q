using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class actions : MonoBehaviour
{
    public string whatISee;
    public Animator doorAnim, bedroomDoorAnim;
    public raycasting raycastobj;
    private bool doorIsOpen, door2IsOpen;
    //public bool onBed;
    private string interactableObj;
    public GameObject laptopScene;
    public player onBedStatus;
    public GameObject phoneScreen;
    public device chat;
    public bool wechatting,discording,planner;
    public GameObject timeManager;
    public laptop laptop;
    public lightswitch bedroomLight, bathroomLight, livingroomLight, kitchenLight;
    public bool bedroomSwitchOn, bathroomSwitchOn, livingroomSwitchOn, kitchenSwitchOn;
    void start()
    {
        //onBed = false;
    }

    
    void Update()
    {
        whatISee = raycastobj.InteractText; //access the object info from raycasting
        
       // Debug.Log(whatISee);
        if (whatISee == "door")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {openTheDoor();}  
        }
        if (whatISee == "bdoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {open2Door();}
        }

        if (whatISee == "msi")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (laptop.laptopOpen == false)
                {
                    laptop.laptopOpen = true;
                }
            }
            if (laptop.laptopOpen == true && Input.GetKeyDown(KeyCode.Escape))
            {
                laptop.laptopOpen = false;
            }
        }
        

        if (whatISee == "bedroomswitch")
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (bedroomLight.isOn == true)
                { 
                    bedroomLight.isOn = false;
                }
                else
                {
                    bedroomLight.isOn = true;
                }
            }   
        }

        if (whatISee == "livingroomswitch")
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (livingroomLight.isOn == true)
                {
                    livingroomLight.isOn = false;
                }
                else
                {
                    livingroomLight.isOn = true;
                }
            }
        }
        if (whatISee == "bathroomswitch")
        {
            
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (bathroomLight.isOn == true)
                {
                    bathroomLight.isOn = false;
                }
                else
                {
                    bathroomLight.isOn = true;
                }
            }
        }
        if (whatISee == "kitchenswitch")
        {
           
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (kitchenLight.isOn == true)
                {
                    kitchenLight.isOn = false;
                }
                else
                {
                    kitchenLight.isOn = true;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (chat.chatIsOn == true)
            {
                chat.chatIsOn = false;
            }
            else
            {
                chat.chatIsOn = true;
            }
        }
        


        if (whatISee == "bed")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                onBedStatus.stop = true;
                goToBed();
            }
        }

        if (onBedStatus.stop ==true) //this condition decides if the player will get on the bed or get off the bed
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                onBedStatus.stop = false;
                goToBed();
            }
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
        if (onBedStatus.stop == false)
        {
            transform.position = new Vector3(-10, 7.42f, -4);
            transform.localEulerAngles = new Vector3(70,0,0);
            onBedStatus.stop = true;
        }
        else
        {
            transform.position = new Vector3(-5, 7.42f, -4);
            onBedStatus.stop = false;
        }
    }

    void laptoptask()
    {

    }
    
}
