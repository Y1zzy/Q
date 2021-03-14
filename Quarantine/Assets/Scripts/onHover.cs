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
    public bool  donefading;
    //string done;
    // Start is called before the first frame update
    void Start()
    {
        logoText.SetActive(false);
        //donefading = true;
        
      
    }

    void Update()
    {
        //Debug.Log("this is from update");
       /* if (donefading == false)
        {
            Debug.Log("this is from update");
            StartCoroutine("WaitForSec");
        }*/
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
        //fading.FadeIn();    //you can't call coroutine in onpointerdown
        Debug.Log("? go through here");
        //donefading = false;
        //fading.FadeOut();
        this.StartCoroutine(this.WaitForSec());
        Debug.Log(donefading);


    }

    public void OnPointerExit (PointerEventData eventData)
    {
        logoText.SetActive(false);
    }

    IEnumerator WaitForSec()
    {
        Debug.Log("sup");
        
        yield return new WaitForSeconds(1);
        Debug.Log("supsupsupsup");
        //innerworld.SetActive(false);
        fading.FadeOut();
        donefading = true;
        //closing = false;
    }

}
