using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wechat : MonoBehaviour
{
    public GameObject msgPrefab;
    public ScrollRect scrollRect;
    public List<string> msgs = new List<string>();
    public List<bool> leftorright = new List<bool>();

    int index = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject msg = Instantiate(msgPrefab, scrollRect.content);
            if (leftorright[index])
            {
                msg.GetComponent<Msg>().ChangeText(msgs[index], true);
            }
            else
            {
                msg.GetComponent<Msg>().ChangeText(msgs[index], false);
            }
            LayoutRebuilder.ForceRebuildLayoutImmediate(scrollRect.content);
            scrollRect.verticalNormalizedPosition = 0;
            index++;
        }
    }
}
