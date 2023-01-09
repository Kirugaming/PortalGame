using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform player;
    public Transform receiver;

    private bool overlap = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (overlap) {
            float dotAngle = Vector3.Dot(transform.up, player.position - transform.position);

            if (dotAngle < 0f) {
                player.Rotate(Vector3.up, -Quaternion.Angle(transform.rotation, receiver.rotation) + 180);

                player.position = receiver.position + (Quaternion.Euler(0f, -Quaternion.Angle(transform.rotation, receiver.rotation), 0f) *  (player.position - transform.position));

                overlap = false;
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            overlap = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            overlap = false;
        }
    }
}
