using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class actions : MonoBehaviour
{
    public string whatISee;
    public Animator doorAnim, bedroomDoorAnim;

    //[HideInInspector]
    //public raycasting raycastobj;
    public GameObject laptopScene;
    //public bool onBed;

    public player onBedStatus;
    public GameObject phoneScreen;
    public device chat;
    public bool wechatting, discording, planner;
    public GameObject timeManager;
    public laptop laptop;
    public bed bed;
    public lightswitch bedroomLight, bathroomLight, livingroomLight, kitchenLight;
    public bool bedroomSwitchOn, bathroomSwitchOn, livingroomSwitchOn, kitchenSwitchOn;
    public GameObject innerworld;
    string innerworldtext;
    string controlguides;
    public GameObject control;
    //TextMesh controltext;
    private bool doorIsOpen, door2IsOpen;
    private string interactableObj;
    void start()
    {
        innerworld.SetActive(false);
        //controlguides = "Press E for Object Interaction";
        //control.GetComponent<TextMeshProUGUI>().text = controlguides;
        //raycastobj = this.GetComponent<raycasting>();
    }


    void Update()
    {
        //whatISee = raycastobj.InteractText; //access the object info from raycasting

        //Debug.Log(whatISee);
        if (whatISee == "door")
        {
            if (Input.GetKeyDown(KeyCode.E))
            { openTheDoor(); }
        }
        if (whatISee == "bdoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            { open2Door(); }
        }

        if (whatISee == "frontdoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                innerworldtext = "Quarantine days";
                innerworld.GetComponent<Text>().text = innerworldtext;
                innerworld.SetActive(true);
                StartCoroutine("WaitForSec");
            }
        }

        if (whatISee == "sofatable")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                innerworldtext = "I didn't want a television because I will never have time to enjoy it";
                innerworld.GetComponent<Text>().text = innerworldtext;
                innerworld.SetActive(true);
                StartCoroutine("WaitForSec");
            }
        }

        if (whatISee == "sofa2")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                innerworldtext = "Why would I sit over here";
                innerworld.GetComponent<Text>().text = innerworldtext;
                innerworld.SetActive(true);
                StartCoroutine("WaitForSec");
            }
        }

        if (whatISee == "fridge")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                innerworldtext = "Do I have enough groceries?";
                innerworld.GetComponent<Text>().text = innerworldtext;
                innerworld.SetActive(true);
                StartCoroutine("WaitForSec");
            }
        }

        if (whatISee == "stove")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                innerworldtext = "Restaurants are closing...";
                innerworld.GetComponent<Text>().text = innerworldtext;
                innerworld.SetActive(true);
                StartCoroutine("WaitForSec");
            }
        }
        if (whatISee == "msi")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (laptop.abletowork == true)
                {
                    if (laptop.laptopOpen == false)
                    {
                        laptop.laptopOpen = true;
                        control.SetActive(false);

                    }
                }
                else
                {
                    innerworldtext = "I think I have done enough, I am too tired";
                    innerworld.GetComponent<Text>().text = innerworldtext;
                    innerworld.SetActive(true);
                    StartCoroutine("WaitForSec");

                }
            }
            if (laptop.laptopOpen == true && Input.GetKeyDown(KeyCode.R))
            {
                laptop.laptopOpen = false;
                control.SetActive(true);
            }
        }

        if (whatISee == "bed")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (bed.sleepOrNot == true)
                { bed.bedTime(); }
                else
                {
                    innerworldtext = "I am not too tired, I don't want to waste my time.";
                    innerworld.GetComponent<Text>().text = innerworldtext;
                    innerworld.SetActive(true);
                    StartCoroutine("WaitForSec");
                }
                //onBedStatus.stop = true;
                //goToBed();
            }
        }

        if (whatISee == "bedroomswitch")
        {
            if (Input.GetKeyDown(KeyCode.E))
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
            if (Input.GetKeyDown(KeyCode.E))
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

            if (Input.GetKeyDown(KeyCode.E))
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

            if (Input.GetKeyDown(KeyCode.E))
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

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            if (chat.deviceOn == false)
            {
                chat.deviceOn = true;
            }
            else
            {
                chat.deviceOn = false;
            }
        }


        

        /*if (onBedStatus.stop == true) //this condition decides if the player will get on the bed or get off the bed
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                onBedStatus.stop = false;
                goToBed();
            }
        }*/


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

        //void goToBed()
        //{
            //Debug.Log("I am on Bed");
            /*if (onBedStatus.stop == false)
            {
                transform.position = new Vector3(-10, 7.42f, -4);
                transform.localEulerAngles = new Vector3(70,0,0);
                onBedStatus.stop = true;
            }
            else
            {
                transform.position = new Vector3(-5, 7.42f, -4);
                onBedStatus.stop = false;
            }*/
        //}

        IEnumerator WaitForSec()
        {
            yield return new WaitForSeconds(1);
            innerworld.SetActive(false);
            //closing = false;
        }
}

