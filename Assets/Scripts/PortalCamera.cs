using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PortalCamera : MonoBehaviour
    {
        public Transform portal;
        public Transform portal2;


         void LateUpdate() {
            Vector3 playerOffsetFromPortal = Camera.main.transform.position - portal2.position;
		        //transform.position = portal.position + playerOffsetFromPortal;
      
      
            float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, portal2.rotation);
    
            Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
            //Vector3 newCameraDirection = portalRotationalDifference * Camera.main.transform.forward;
            //transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
         }
    }
}