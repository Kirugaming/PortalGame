using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDestroyer : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Cube"))
        {
            Destroy(other.gameObject);
        }
    }
    void Start()
    {

    }


    void Update()
    {

    }
}
