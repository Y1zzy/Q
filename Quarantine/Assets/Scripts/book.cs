using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    public timer time;
    public bool readable;
    public bool bookread;
    public day1Progress day;
    public string kobe;
    //public string godfather;
    // Start is called before the first frame update
    void Start()
    {
        readable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void readTime()
    {
        time.hoursread += 1;
        time.initialhr += 1;
        bookread = true;
    }

    public void differentdaydifferentquote()
    {
        switch (day.chapter)
        {
            case 1:
                kobe = "Motivational, I work hard for myself";
                
                break;
            case 2:
                kobe = "RIP Kobe, you are so inspirational";
                break;
            case 3:
                kobe = "BBall is my spiritual sustenance";

                break;
            case 4:
                kobe = "I wish I can be as tough as he does";
                break;
            case 5:
                kobe = "why can he this tough but I still need others' presense";

                break;
            case 6:
                kobe = "......";

                break;
            case 7:
                kobe = "How can I get his mentality? I am so soft and emotional";
                break;
            case 8:
                kobe = "One needs support but also have confidence.";
                break;
        }
    }
}
