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
            Vector3 portalToPlayer = player.position - transform.position;
            float dotAngle = Vector3.Dot(transform.up, player.position - transform.position);

            if (dotAngle < 0f) {

                float rotationDiff = Quaternion.Angle(transform.rotation, receiver.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);


                player.position = receiver.position + (Quaternion.Euler(0f, rotationDiff, 0f) *  portalToPlayer);

                overlap = false;
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Debug.Log("test");
            overlap = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            overlap = false;
        }
    }
}