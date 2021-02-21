using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed : MonoBehaviour
{
    public bool onBedStatus;
    public int hoursRested;
    // Start is called before the first frame update
    void Start()
    {
        //onBedStatus = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (onBedStatus == false)
        {
            transform.position = new Vector3(-10, 7.42f, -4);
            transform.localEulerAngles = new Vector3(70, 0, 0);
            onBedStatus = true;
            hoursRested += 2;
        }
        else
        {
            transform.position = new Vector3(-5, 7.42f, -4);
            onBedStatus = false;
            
        }
}
