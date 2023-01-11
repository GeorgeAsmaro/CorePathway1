using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedPlayerController : MonoBehaviour
{
    float xSens;
    float ySens;

    public Transform Orientation;

    float xRotation;
    float yRotation;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update() {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * xSens;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * ySens;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation,-90f,90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        Orientation.transform = Quaternion.Euler(0f,yRotation,0f);
    }

}
