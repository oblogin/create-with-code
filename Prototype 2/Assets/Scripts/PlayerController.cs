using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, 0, 0);
        }

        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, 0, 0);
        }

        transform.Translate(horizontalInput * speed * Time.fixedDeltaTime * Time.timeScale, 0, 0);
    }
}