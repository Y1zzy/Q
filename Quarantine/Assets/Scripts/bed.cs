using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed : MonoBehaviour
{
    public bool onBedStatus;
    public timer time;
    //public int hoursRested;
    public bool sleepOrNot;
    public int bedTimehr, bedTimeMin;
    public bool toTheNextDay;
    // Start is called before the first frame update
    void Start()
    {
        sleepOrNot = false;
    }

    // Update is called once per frame
    void Update()
    {

        /*if (onBedStatus == false)
        {
            transform.position = new Vector3(-10, 7.42f, -4);
            transform.localEulerAngles = new Vector3(70, 0, 0);
            onBedStatus = true;
            hoursRested += 2;
        }
        else
        {
            transform.position = new Vector3(-5, 7.42f, -4);
            onBedStatus = false;

        }*/
    }

    public void bedTime()
    {
        time.hoursrested += 1;
        time.initialhr += 1;
        
    }
}
