using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laptop : MonoBehaviour
{
    public GameObject screen;
    public bool laptopOpen;
    // Start is called before the first frame update
    void Start()
    {
        laptopOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (laptopOpen == false)
        {
            screen.SetActive(false);
        }
        if (laptopOpen == true)
        {
            screen.SetActive(true);
        }
    }
}
