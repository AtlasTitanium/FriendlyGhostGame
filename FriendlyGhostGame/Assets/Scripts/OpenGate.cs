using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour {
	public GameObject ThePlayer;
	public Collider triggerOpen;
	public Animator animatorLeftDoornowere;
	public Animator animatorRightDoornowere;

	public AudioSource fenceaudio;

	void OnTriggerEnter(Collider other){
		if(other == triggerOpen){
			fenceaudio.Play();
			animatorLeftDoornowere.Play("GateOpen2");
			animatorRightDoornowere.Play("GateOpen");
		}
	}
}
