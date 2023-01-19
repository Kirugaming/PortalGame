using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    // Update is called once per frame - sets the camera to the right spot
    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
