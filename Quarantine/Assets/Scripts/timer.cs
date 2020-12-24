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
    public Text calendar;
    public int initialhr = 11, initialmin = 37;
    public GameObject daylight;
    public Light lightValue;
    public int taskhr, taskmin, tasksecond;
    
    // Start is called before the first frame update
    void Start()
    {
        //startTime = Time.time;
        lightValue = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        
        second = (int)(startTime%60);
        minute = initialmin + (int)(startTime / 60)%60;
        hour = initialhr + (int)(startTime / 3600) % 24;
        timeText.text = string.Format("{0:0}:{1:00}:{2:00}",hour,minute,second);
        
        calendar.text = "Mar.9th 2020";

    }
}
