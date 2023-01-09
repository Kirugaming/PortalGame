using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class PlayerCam : MonoBehaviour
{

    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRotation;
    float yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // input manager stuff
        float mouseX = Input.GetAxisRaw("Mouse X")  * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y")  * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // camera
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}
