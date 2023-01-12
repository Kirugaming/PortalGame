using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigOpenDoor : MonoBehaviour
{
    public GameObject door;
    private Vector3 oldPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Button Pressed");
        oldPos = door.transform.localPosition; 
        door.transform.localPosition = new Vector3(100, 0, 0);
        //Destroy(door);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Button Unpressed");
        door.transform.localPosition = oldPos;
    }
}
