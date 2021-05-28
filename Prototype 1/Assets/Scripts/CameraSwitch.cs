using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera mainCamera;
    public Camera frontCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (mainCamera.enabled == true)
            {
                mainCamera.enabled = false;
                frontCamera.enabled = true;
            }
            else
            {
                mainCamera.enabled = true;
                frontCamera.enabled = false;
            }
        }
    }
}