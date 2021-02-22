using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycasting : MonoBehaviour
{
    public float distanceToSee;
    public RaycastHit whatIHit;
    public GameObject uiObject;
    public string InteractText = "null";
    public string objectName;
    public Camera camera;

    private bool closing = false;
    
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        //color neglegible
        if (Physics.Raycast(ray, out whatIHit, distanceToSee))
        {
            
            //Debug.Log("the tag is " + whatIHit.collider.gameObject.tag);
            if (whatIHit.collider.gameObject.tag == "Interactable")
            {
                if(uiObject.active == false)
                {
                    uiObject.SetActive(true);
                    //Debug.Log("raycasting" +whatIHit.collider.gameObject.name);
                    InteractText = whatIHit.collider.gameObject.name;

                    objectName = uiObject.GetComponent<Text>().text.ToString();

                    objectName = InteractText;
                    this.GetComponent<actions>().whatISee = objectName;
                    uiObject.GetComponent<Text>().text = objectName;
                    
                }
            }
            else
            {
                InteractText = "null";
                this.GetComponent<actions>().whatISee = InteractText;
            }
        }
        else
        {
            InteractText = "null";
            this.GetComponent<actions>().whatISee = InteractText;
            if (uiObject.active)
            {
                if (!closing)
                {
                    closing = true;
                    StartCoroutine("WaitForSec");
                }
            }
            
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        uiObject.SetActive(false);
        Debug.Log(uiObject.GetComponent<Text>().text);
        uiObject.GetComponent<Text>().text = "null";
       

        closing = false;
    }
}
