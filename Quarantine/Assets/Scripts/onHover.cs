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
    public Animator fadeanimation;
    public laptop screen;
    //public Text accomplished;
    private string done;
    public string accomplishedtext;
    //string done;
    // Start is called before the first frame update
    void Start()
    {
        logoText.SetActive(false);
        
        
        //done = accomplished.GetComponent<Text>().text.ToString();
        //done = accomplishedtext;
        //accomplishedtext = done.text.ToString();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        logoText.SetActive(true);
       
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("sup");
        Time.initialhr += customizedHour;
        screen.laptopOpen = false;
        //accomplished.SetActive(true);
        //fadeanimation.SetTrigger("Fadeout");
    }

    public void OnPointerExit (PointerEventData eventData)
    {
        logoText.SetActive(false);
    }
    
    
}
