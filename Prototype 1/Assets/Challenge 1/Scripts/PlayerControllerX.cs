using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 45.0f;
    public float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        // получить вертикальный ввод пользователя
        verticalInput = Input.GetAxis("Vertical");

        // перемещать самолет вперед с постоянной скоростью
        transform.Translate(Vector3.forward * (Time.fixedDeltaTime * speed * Time.timeScale));

        // наклон самолета вверх/вниз на основе клавиш со стрелками вверх/вниз
        transform.Rotate(Vector3.left, verticalInput * rotationSpeed * Time.fixedDeltaTime * Time.timeScale);
    }
}
