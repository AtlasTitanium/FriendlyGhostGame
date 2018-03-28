using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDistort : MonoBehaviour {
	public Animator anim;

	bool ye = false;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Evil"){
			ye = true;
			readyanim();
		}
	}
	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Evil"){
			ye = false;
			readyanim();
		}
	}

	void readyanim(){
		if(ye){
			anim.Play("CameraDistorionStart");
		} else {
			anim.Play("CameraDistorionEnd");
		}
	}
}
