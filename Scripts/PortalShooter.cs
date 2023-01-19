using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

public class PortalShooter : MonoBehaviour
{
    public GameObject inPortalPrefab;
    public GameObject outPortalPrefab;
    public Camera playerCamera;
    private Ray ray;

    private GameObject _currentInPortal;
    private GameObject _currentOutPortal;

    private PortalTexture _portalTexture;
    // Start is called before the first frame update
    void Start()
    {
        _currentInPortal = GameObject.Find("InPortal 1");
        _currentOutPortal = GameObject.Find("OutPortal");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            Debug.DrawRay(ray.origin, ray.direction * 10);
            RaycastHit hitData;
            if (Physics.Raycast(transform.position,
                    playerCamera.transform.forward,
                    out hitData,
                    float.MaxValue,
                    LayerMask.GetMask(new[] { "wall" })))
            {

                _currentInPortal.transform.position = hitData.point + hitData.normal * .02f;
                _currentInPortal.transform.rotation = Quaternion.LookRotation(-hitData.normal,
                    hitData.normal.y >= 0f ? transform.up : transform.forward);
                //_currentInPortal.transform.rotation = Quaternion.Euler(_currentInPortal.transform.rotation.x, 180, 0);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            RaycastHit hitData;
            if (Physics.Raycast(transform.position,
                    playerCamera.transform.forward,
                    out hitData,
                    float.MaxValue,
                    LayerMask.GetMask(new[] { "wall" })))
            {


                _currentOutPortal.transform.position = hitData.point + hitData.normal * .02f;
                _currentOutPortal.transform.rotation = Quaternion.LookRotation(-hitData.normal,
                    hitData.normal.y >= 0f ? transform.up : transform.forward);
                //inPortal.transform.rotation = Quaternion.Euler(inPortal.transform.rotation.x, 180, 0);
            }
        }
        
    }
}
