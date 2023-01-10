using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTexture : MonoBehaviour
{
    public Camera portal1;
    public Camera portal2;
    public Material portalMaterial1;
    public Material portalMaterial2;

    // Start is called before the first frame update
    void Start()
    {
        if (portal1.targetTexture != null)
		{
			portal1.targetTexture.Release();
		}
		portal1.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
		portalMaterial2.mainTexture = portal1.targetTexture;

        if (portal2.targetTexture != null) {
            portal2.targetTexture.Release();
        }   
        portal2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        portalMaterial2.mainTexture = portal2.targetTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
