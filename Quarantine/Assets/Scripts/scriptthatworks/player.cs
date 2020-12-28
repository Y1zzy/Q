using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    
    [SerializeField] private string horizontalInputName, verticalInputName;
    [SerializeField] private float movementSpeed;
    //public actions movement;
    public bool stop;
    private CharacterController charController;



    void Awake()
    {
        charController = GetComponent<CharacterController>();
    }



    void Update()
    {

        //isOnBed = movement.onBed;
        
        PlayerMovement();
 
        
    }

    void PlayerMovement()
    {
        
        float horizInput = Input.GetAxis(horizontalInputName) *movementSpeed * Time.deltaTime;
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed * Time.deltaTime;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(Vector3.ClampMagnitude(forwardMovement + rightMovement, 1.0f) * movementSpeed);
        
    }
    

    
}
