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
    public Light daylight;
    public int taskhr, taskmin, tasksecond;
    private float angle;
    public float intensitySpeed = 0.5f;
    public float minIntensity = 0f;
    public bool changeIntensity = true;

    public bool changeColors = true;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;
    // Start is called before the first frame update
    void Start()
    {
        //startTime = Time.time;
        daylight = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        angle = startTime * 0.000002f;
        //daylight.GetComponent<Transform>.RotateAround(Vector3.zero, Vector3.forward, angle);
        
        second = (int)(startTime%60);
        minute = initialmin + (int)(startTime / 60)%60;
        hour = initialhr + (int)(startTime / 3600) % 24;
        timeText.text = string.Format("{0:0}:{1:00}:{2:00}",hour,minute,second);
        
        calendar.text = "Mar.9th 2020";
        if (changeIntensity)
        {
            daylight.intensity = Mathf.PingPong(Time.deltaTime * intensitySpeed, minIntensity);
        }

        if (changeColors)
        {
            float t = (Mathf.Sin(Time.deltaTime - startTime * colorSpeed));
            daylight.color = Color.Lerp(startColor, endColor, t);
        }
    }
}
