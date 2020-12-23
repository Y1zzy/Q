using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour
{
    public Animator doorAnim;
    public bool doorOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
