using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycasting : MonoBehaviour
{
    public float distanceToSee;
    public RaycastHit whatIHit;
    public GameObject uiObject;
    public string InteractText;
    public string objectName;
    //private string objTag;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);

        InteractText = "null";

        //color neglegible
        if (Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {
            
            Debug.Log("the tag is " + whatIHit.collider.gameObject.tag);
            if (whatIHit.collider.gameObject.tag == "Interactable")
            {
                Debug.Log("raycasting" +whatIHit.collider.gameObject.name);
                InteractText = whatIHit.collider.gameObject.name;

                objectName = uiObject.GetComponent<Text>().text.ToString();


                objectName = InteractText;

                uiObject.GetComponent<Text>().text = objectName;
                uiObject.SetActive(true);
                StartCoroutine("WaitForSec");
            }
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        uiObject.SetActive(false);
        
    }
}
