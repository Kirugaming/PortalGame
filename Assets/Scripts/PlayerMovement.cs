using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class PlayerMovement : MonoBehaviour
{
    public Camera playerCamera; // make private
    public float cameraSpeed;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // input manager stuff
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        // player
        transform.Translate(new Vector3(horizontal, 0, vertical) * (10 * Time.deltaTime));

        // camera
        playerCamera.transform.eulerAngles += cameraSpeed * new Vector3( -mouseY, mouseX,0) ; 


    }
}
