using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject objectCam;
    public GameObject topviewCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("1Key"))
        {
            topviewCam.SetActive(true);
            objectCam.SetActive(false);
        }
        if (Input.GetButtonDown("2Key"))
        {
            objectCam.SetActive(true);
            topviewCam.SetActive(false);
        }
    }
}
