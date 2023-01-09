using UnityEngine;
using UnityEngine.Rendering;

namespace DefaultNamespace
{
    public class PortalCamera : MonoBehaviour
    {
        public Transform playerCamera;
        public Transform portal;
        public Transform portal2;

        void update() {
            transform.position = portal.position + (playerCamera.position - portal2.position);

            // offset rotations
            transform.rotation = Quaternion.LookRotation(
                Quaternion.AngleAxis(Quaternion.Angle(portal.rotation, portal2.rotation), Vector3.up) * playerCamera.forward,
                Vector3.up
            );
        }
    }
}