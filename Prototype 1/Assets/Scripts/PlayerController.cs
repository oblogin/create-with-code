using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Независимое от частоты кадров сообщение для расчетов физики.
    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * (forwardInput * Time.fixedDeltaTime * Time.timeScale * speed));
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.fixedDeltaTime * Time.timeScale);
    }
}