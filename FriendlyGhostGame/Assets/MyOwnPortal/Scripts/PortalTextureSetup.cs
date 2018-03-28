using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour {

	public Camera cameraR2;
	public Camera cameraR1;
	public Material cameraMatR2;
	public Material cameraMatR1;

	// Use this for initialization
	void Start () {
		if(cameraR2.targetTexture != null){
			cameraR2.targetTexture.Release();
		}
		cameraR2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
		cameraMatR2.mainTexture = cameraR2.targetTexture;

		if(cameraR1.targetTexture != null){
			cameraR1.targetTexture.Release();
		}
		cameraR1.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
		cameraMatR1.mainTexture = cameraR1.targetTexture;
	}
	
}
