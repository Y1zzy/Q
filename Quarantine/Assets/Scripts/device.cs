using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class device : MonoBehaviour
{
    public GameObject chatOn;
    public GameObject chatOff;
    public bool chatIsOn;
    // Start is called before the first frame update
    void Start()
    {
        chatIsOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (chatIsOn == false)
        {
            chatOff.SetActive(true);
            chatOn.SetActive(false);
            
        }
        if (chatIsOn == true)
        {
            chatOff.SetActive(false);
            chatOn.SetActive(true);
           
        }
    }
}
