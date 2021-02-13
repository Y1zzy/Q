using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class onHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject logoText;
    public int customizedHour;
    public timer Time;
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
        Debug.Log("sup");
        Time.initialhr += customizedHour;
    }

    public void OnPointerExit (PointerEventData eventData)
    {
        logoText.SetActive(false);
    }
    
}
