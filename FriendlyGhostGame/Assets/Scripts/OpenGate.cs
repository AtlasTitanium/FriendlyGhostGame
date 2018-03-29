using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour {
	public GameObject ThePlayer;
	public Collider triggerOpen;
	public Animator animatorLeftDoornowere;
	public Animator animatorRightDoornowere;

	public AudioSource fenceaudio;
	private bool onlyonce = true;

	void OnTriggerEnter(Collider other){
		if(other == triggerOpen){
			if(onlyonce){
				fenceaudio.Play();
				onlyonce = false;
			}
			animatorLeftDoornowere.Play("GateOpen2");
			animatorRightDoornowere.Play("GateOpen");
		}
	}
}
