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
    public int hoursworked,hoursrested,hourseat,hoursread;
    public day1Progress day;
    
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
        Debug.Log(startTime);
        second = (int)(startTime%60);
        minute = initialmin + (int)(startTime / 60)%60;
        hour = initialhr + (int)(startTime / 3600) % 24;
        if (hour > 24)
        {

            hour -= 24;
            day.date += 1;
            //Debug.Log("dyae: " + day.date);
        }
        timeText.text = string.Format("{0:0}:{1:00}:{2:00}",hour,minute,second);
        
        //calendar.text = "Mar.9th 2020";
        sunlight();
    }

    void sunlight()
    {
        // 0 - 4 night
        // 5 - 10 morning
        // 11 - 14 noon
        // 15 - 17 afternoon
        // 18 - 23 evening
        if (hour >= 8 && hour <12)
        {
            
            daylight.transform.localEulerAngles = new Vector3(23.2f, -218.96f, -156.342f);
            lightValue.intensity = 1.2f;
            RenderSettings.ambientLight = new Color(255 / 255f, 250 / 255f, 199 / 255f, 0 / 255f);
        }
       
        
        if (hour >= 12 && hour < 18)
        {
            
            daylight.transform.localEulerAngles = new Vector3(16.0f, -203f, -151f);
            lightValue.intensity = 1.2f;
            RenderSettings.ambientLight = new Color(255 / 255f, 255 / 255f, 255 / 255f, 0 / 255f);
        }
        
        if (hour >= 18 || hour < 8)
        {
            
            daylight.transform.localEulerAngles = new Vector3(-7f, -165f, -140f);
            RenderSettings.ambientLight = new Color(0 / 255f, 0 / 255f, 0 / 255f, 0 / 255f);
            lightValue.intensity = 0.0f;
            daylight.SetActive(false);
        }

    }
}
