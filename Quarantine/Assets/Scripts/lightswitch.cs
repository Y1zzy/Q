using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;
    public bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn == false)
        {
            light1.SetActive(false);
            light2.SetActive(false);
            light3.SetActive(false);
            light4.SetActive(false);
            light5.SetActive(false);
            light6.SetActive(false);
        }
        if (isOn == true)
        {
            light1.SetActive(true);
            light2.SetActive(true);
            light3.SetActive(true);
            light4.SetActive(true);
            light5.SetActive(true);
            light6.SetActive(true);
        }
    }
}
