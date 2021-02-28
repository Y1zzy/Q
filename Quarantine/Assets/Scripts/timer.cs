using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public string month, date, year;
    public int hour,minute,second;
    private float startTime;
    public Text timeText;
    //public Text calendar;
    public int dayInMonth;
    public int initialhr = 11, initialmin = 37;
    public GameObject daylight;
    public Light lightValue;
    public float angle;
    public int hoursworked,hoursrested;
    
    //public int taskhr, taskmin, tasksecond;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //startTime = Time.time;
        initialhr = 11;
        initialmin = 37;
        lightValue = daylight.GetComponent<Light>();
       
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        
        second = (int)(startTime%60);
        minute = initialmin + (int)(startTime / 60)%60;
        hour = initialhr + (int)(startTime / 3600) % 24;
        if (hour > 24)
        {
            hour -= 24;
        }
        timeText.text = string.Format("{0:0}:{1:00}:{2:00}",hour,minute,second);
        
        //calendar.text = "Mar.9th 2020";
        sunlight();
    }

    void sunlight()
    {
        
        if (hour >= 8 && hour <12)
        {
            
            daylight.transform.localEulerAngles = new Vector3(20.0f, -218.96f, -156.342f);
            lightValue.intensity = 1.2f;
        }
       
        
        if (hour >= 12 && hour < 14)
        {
            
            daylight.transform.localEulerAngles = new Vector3(8.0f, -218.96f, -156.342f);
            lightValue.intensity = 0.6f;
        }
        if (hour >= 14 && hour < 20)
        {
            
            daylight.transform.localEulerAngles = new Vector3(5.0f, -218.96f, -156.342f);
            lightValue.intensity = 0.4f;
        }
        if (hour >= 20 || hour < 8)
        {
            
            daylight.transform.localEulerAngles = new Vector3(0f, -218.96f, -156.342f);
            lightValue.intensity = 0.0f;
            daylight.SetActive(false);
        }

    }
}
