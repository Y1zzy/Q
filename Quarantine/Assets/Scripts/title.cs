using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour, IPointerDownHandler
{
    //public Text startButton;
    public GameObject creditScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*private void Update()
    {
        
    }*/

    // Update is called once per frame
    public void OnPointerDown(PointerEventData eventData)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        creditScene.SetActive(true);
    }
}
