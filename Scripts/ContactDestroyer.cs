<<<<<<< HEAD
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
=======
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
>>>>>>> 0db7792816b6bfca9e1ab0ac87902571a1bfec7b
