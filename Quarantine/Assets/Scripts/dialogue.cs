using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dialogue : MonoBehaviour
{

    //public GameObject chatPanel, textObject;
    public Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            Debug.Log("pressed");
        }
    }

  
}
[System.Serializable]
public class Message
{
    public string[] sentences;
    //public Text textobject;
}

