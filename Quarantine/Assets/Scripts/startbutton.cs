using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour, IPointerDownHandler
{
    //public Animator transition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnPointerDown(PointerEventData eventData)
    {
        //transition.SetTrigger("fadeout");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //creditScene.SetActive(true);

    }

    
}
