using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class onHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject logoText;
    public int customizedHour;
    public timer Time;
    //public Animator fadeanimation;
    public laptop screen;
    //public GameObject innerworld;
    //private int hoursofworking;
    //public Text accomplished;
    //private string done;
    public string accomplishedtext;
    public fade fading;
    //string done;
    // Start is called before the first frame update
    void Start()
    {
        logoText.SetActive(false);
        
        
      
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        logoText.SetActive(true);

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        Time.initialhr += customizedHour;
        Time.hoursworked += customizedHour;
        Time.hoursrested -= customizedHour/2;
        screen.laptopOpen = false;
        fading.FadeIn();
        Debug.Log("? go through here");
        fading.FadeOut();
        //StartCoroutine("WaitForSec");
        Debug.Log("how about here");


    }

    public void OnPointerExit (PointerEventData eventData)
    {
        logoText.SetActive(false);
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("here?");
        fading.FadeOut();
        //canvas.SetActive(false);
    }

}
