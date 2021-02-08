using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Msg : MonoBehaviour
{
    public Text msgText;
    // Start is called before the first frame update
    public void ChangeText(string txt, bool LeftAlignment)
    {
        msgText.text = txt;
        if (LeftAlignment)
        {
            msgText.GetComponent<Text>().alignment = TextAnchor.UpperLeft;
        }
        else
        {
            msgText.GetComponent<Text>().alignment = TextAnchor.UpperRight;
        }
    }

}
