using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet : MonoBehaviour {
    public GameObject Light;
	public GameObject Lightlight;
	public GameObject Camera;
	public GameObject CameraLight;

	public Animator LightAnim;

	public Animator Cameraanim;
	bool flag = true;
	bool fleg = true;
	
 	void Update () {
     	if(Input.GetKeyDown(KeyCode.Tab)){
			if(fleg){
			flag = !flag; //set flag to opposite value
			//Debug.Log("flag is " + flag);
			changer();
			}
     	}
		if(Input.GetKeyDown(KeyCode.Q)){
			if(flag){
			fleg = !fleg; //set flag to opposite value
			//Debug.Log("fleg is " + fleg);
			changer2();
			}
     	}
 	}
	
	void changer(){
		if(flag){       
			Lightlight.SetActive(false);
         	LightAnim.SetTrigger("ClickTab");
			//Debug.Log("Light is " + Light.activeSelf);
			//tablet.GetComponent<Animation>().Play();
     	} else {
			Lightlight.SetActive(true);
         	LightAnim.SetTrigger("ClickTab");
			//Debug.Log("Light is " + Light.activeSelf);
			//tablet.GetComponent<Animation>().Play();
     	}
	} 
	void changer2(){
		if(fleg){     
			CameraLight.SetActive(false);  
			Cameraanim.SetTrigger("Clickq");
			//Debug.Log("Camera is " + Camera.activeSelf);
			//Camera.GetComponent<Animation>().Play();
     	} else {
			Cameraanim.SetTrigger("Clickq");
			CameraLight.SetActive(true);
			//Debug.Log("Camera is " + Camera.activeSelf);
			//Camera.GetComponent<Animation>().Play();
     	}
	}
}
