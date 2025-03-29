using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensistivity = 2.0f; // Чувствительность мыши
    public float maxYAngle = 80.0f; // Максимальный угол вращенения по вертикали

    private float rotationX = 0.0f;

    private void Update()
    {
        // Получаем ввод от мыши
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Вращение персонажа в горизонтальной плоскости
        transform.parent.Rotate(Vector3.up * mouseX * sensistivity);

        // Вращаем камеру в вертикальной плоскости
        rotationX -= mouseY * sensistivity;
        rotationX = Mathf.Clamp(rotationX, -maxYAngle, maxYAngle);
        transform.localRotation = Quaternion.Euler(rotationX, 0.0f, 0.0f);

        
    }
}
