using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WTFEven : MonoBehaviour {

	void OnMouseDown(){
		GetComponent<Renderer> ().material.color = Color.red;
	}
}
