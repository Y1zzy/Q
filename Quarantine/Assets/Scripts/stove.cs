using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stove : MonoBehaviour
{
    public bool hungry;
    public int hourscooked = 1;
    public timer time;
    public bool mealcooked;
    
    // Start is called before the first frame update
    void Start()
    {
        hourscooked = 1;
        //mealcooked = false;
        //hungry = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mealTime()
    {
        time.hourseat += 1;
        time.initialhr += 1;
        mealcooked = true;
    }


}
