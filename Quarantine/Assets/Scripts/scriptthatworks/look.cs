using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;
    [SerializeField] private Transform playerbody;
    private float xAxisClamp;

    private void Awake()
    {
        LockCursor();
        xAxisClamp = 0.0f;
        //charController = GetComponent<CharacterController>();
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 45.0f)
        {
            xAxisClamp = 45.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(315.0f);
        }
        else if (xAxisClamp < -45.0f)
        {
            xAxisClamp = -45.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(45.0f);
        }
        transform.Rotate(Vector3.left * mouseY);
        playerbody.Rotate(Vector3.up * mouseX);


    }

    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
