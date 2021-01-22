using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dialogue : MonoBehaviour
{

    public GameObject chatPanel, textObject;

    [SerializeField]
    List<Message> messageList = new List<Message>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pressed");
        }
    }

    public void chat()
        {
        }
}
[System.Serializable]
public class Message
{
    public string text;
    public Text textobject;
}

