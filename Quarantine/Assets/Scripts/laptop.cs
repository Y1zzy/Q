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
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            screen.SetActive(false);
        }
        if (laptopOpen == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            screen.SetActive(true);
        }
    }
}
