using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	public GameObject target;
	public Material Blue;
	public Material Red;
	public Color Redcolr = new Color(0.2F, 0.3F, 0.4F, 0.5F);

	void Start()
    {
        //Fetch the Material from the Renderer of the GameObject
        Blue = GetComponent<Renderer>().material;
		Red = GetComponent<Renderer>().material;
    }
	// Update is called once per frame
	void Update()
    {
		if(Input.GetMouseButtonDown(1)){
			Blue.color = Red.color;
			Blue.SetColor ("_EmissionColor", Redcolr);
		}	
        // Rotate the camera every frame so it keeps looking at the target
    }
}
