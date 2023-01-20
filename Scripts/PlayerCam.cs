<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class PlayerCam : MonoBehaviour
{
    //instance variables
    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRotation;
    float yRotation;

    void Start()
    {
        //makes the cursor locked in the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // input manager stuff
        float mouseX = Input.GetAxisRaw("Mouse X")  * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y")  * Time.deltaTime * sensY;

        //calculates the x and y rotation based off of player input
        yRotation += mouseX;
        xRotation -= mouseY;

        //makes it so you cant look in circles up and down
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //applies the rotation to the camera- allowing for mouse controlled pov
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class PlayerCam : MonoBehaviour
{
    //instance variables
    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRotation;
    float yRotation;

    void Start()
    {
        //makes the cursor locked in the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // input manager stuff
        float mouseX = Input.GetAxisRaw("Mouse X")  * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y")  * Time.deltaTime * sensY;

        //calculates the x and y rotation based off of player input
        yRotation += mouseX;
        xRotation -= mouseY;

        //makes it so you cant look in circles up and down
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //applies the rotation to the camera- allowing for mouse controlled pov
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}
>>>>>>> 0db7792816b6bfca9e1ab0ac87902571a1bfec7b
