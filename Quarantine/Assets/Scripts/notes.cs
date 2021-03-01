using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class notes : MonoBehaviour
{
    public GameObject notedate;
    day1Progress chapter;
    public GameObject task;
    public GameObject task1;
    public GameObject task2;
    public GameObject task3;
    public GameObject task4;
    public GameObject task5;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
   

    public void switchTask()
    {
        switch (chapter.chapter)
        {
            case 1:
                notedate.GetComponent<Text>().text = "03 - 09 -2020"; 

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
