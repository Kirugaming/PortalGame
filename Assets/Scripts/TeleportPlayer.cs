using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform player;
    public Transform receiver;

    private bool overlap = false;
    private GameObject currentObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (overlap) {
            if (GameObject.Find("outPortal(Clone)") != null)
            {
                receiver = GameObject.Find("outPortal(Clone)").transform;
                float dotAngle = Vector3.Dot(transform.up, currentObject.transform.position - transform.position);
                Debug.Log("test");
                if (dotAngle < 0f) {
                    currentObject.transform.Rotate(Vector3.up, -Quaternion.Angle(transform.rotation, receiver.rotation) + 180);

                    currentObject.transform.position = receiver.position + (Quaternion.Euler(0f, -Quaternion.Angle(transform.rotation, receiver.rotation), 0f) *  (currentObject.transform.position - transform.position));

                    overlap = false;
                } 
            }
            
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            overlap = true;
            currentObject = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            overlap = false;
            currentObject = null;
        }
    }
}
