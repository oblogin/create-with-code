using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Awake вызывается во время загрузки экземпляра сценария.
    private void Awake()
    {
        
    }
    
    // Start вызывается перед обновлением первого кадра
    void Start()
    {
        
    }

    // Update вызывается один раз за кадр
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
    
    // Независимое от частоты кадров сообщение для расчетов физики.
    private void FixedUpdate()
    {
        // transform.Translate(Vector3.forward * Time.fixedDeltaTime * Time.timeScale * 20);
    }
}
