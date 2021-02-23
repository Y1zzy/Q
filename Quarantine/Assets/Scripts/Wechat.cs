using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wechat : MonoBehaviour
{
    public GameObject msgPrefab;
    public GameObject msgPrefab2;
    public ScrollRect scrollRect;
    public timer timeRn;
    public List<string> msgs = new List<string>();
    public List<string> msgs1 = new List<string>();
    public List<string> msgs2 = new List<string>();
    public List<string> msgs3 = new List<string>();

    public List<bool> leftorright = new List<bool>();
    public List<bool> leftorright1 = new List<bool>();
    public List<bool> leftorright2 = new List<bool>();
    public List<bool> leftorright3 = new List<bool>();

    private List<string> Current_Msg_List = new List<string>();
    private List<bool> Current_LeftorRight_List = new List<bool>();

    int index = 0;
    int maxSize = 0;
    public string time = "0:00";


    public void MIAOUPDATEUPDATE()// call when time changes!!!!
    {
        switch (time)
        {
            case "0:00":
                maxSize = msgs.Count;
                Current_Msg_List = msgs;
                Current_LeftorRight_List = leftorright;
                break;
            case "5:00":
                maxSize = msgs1.Count;
                Current_Msg_List = msgs1;
                Current_LeftorRight_List = leftorright1;
                break;
            case "24:00":
                maxSize = msgs2.Count;
                Current_Msg_List = msgs2;
                Current_LeftorRight_List = leftorright2;
                break;
        }
    }

    private void Start()
    {
        time = "0:00";
        MIAOUPDATEUPDATE();
    }

    void Update()
    {
        if (index < maxSize)
            {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                GameObject msg = Instantiate(msgPrefab, scrollRect.content);
                //GameObject msg = Instantiate(msgPrefab2, scrollRect.content);
                if (Current_LeftorRight_List[index])
                {
                    //GameObject msg = Instantiate(msgPrefab, scrollRect.content);
                    msg.GetComponent<Msg>().ChangeText(Current_Msg_List[index], true);
                }
                else
                {
                    //GameObject msg2 = Instantiate(msgPrefab2, scrollRect.content);
                    msg.GetComponent<Msg>().ChangeText(Current_Msg_List[index], false);
                }
                scrollRect.verticalNormalizedPosition = 0;
                //LayoutRebuilder.ForceRebuildLayoutImmediate(scrollRect.content);
                index++;
            }
        }

        if (Input.GetKeyDown(KeyCode.A)) //this is to destroy
        {
            index = 0;
            for(int i = 0; i < scrollRect.content.childCount; i++)
            {
                GameObject child = scrollRect.content.GetChild(i).gameObject;
                Destroy(child);
            }
        }
    }
}
