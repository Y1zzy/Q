using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform MirrorCam;
    public Transform PlayerCam;
    void Update()
    {
        CalculateRotation();
    }

    // Update is called once per frame
    public void CalculateRotation()
    {
        Vector3 dir = (PlayerCam.position - transform.position).normalized;
        Quaternion rot = Quaternion.LookRotation(dir);

        rot.eulerAngles = transform.eulerAngles - rot.eulerAngles;

        MirrorCam.localRotation = rot;

    }
}
