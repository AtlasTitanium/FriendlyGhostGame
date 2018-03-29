using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndClose : MonoBehaviour {
	public GameObject managerOfSound;
	public GameObject ThePlayer;
	public GameObject thePlayerMusic;
	public Collider triggerOpen;
	public Collider triggerClose;

	//public Animator animatorLeftDoor;
	//public Animator animatorRightDoor;
	public AudioSource OpenDoor;
	public AudioSource ShutDoor;

	public Animator animatorLeftDoornowere;
	public Animator animatorRightDoornowere;

	private bool playedOpen = false;
	private bool playedClose = false;
	// Use this for initialization
	void Start () {
		//animatorLeftDoor = GetComponent<Animator>();
		//animatorRightDoor = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other == triggerClose){
			ThePlayer.GetComponent<Tablet>().enabled = true;
			thePlayerMusic.GetComponent<SoundManager>().playerisinside = true;
			//animatorLeftDoor.Play("DoorClose");
			//animatorRightDoor.Play("DoorClose2");
			if(!playedClose){
				ShutDoor.Play();
				playedClose = true;
				managerOfSound.GetComponent<SoundManager>().playerisinside = true;
			}
			animatorLeftDoornowere.Play("DoorClose");
			animatorRightDoornowere.Play("DoorClose2");
		}

		if(other == triggerOpen){
			//animatorLeftDoor.Play("DoorOpen");
			//animatorRightDoor.Play("DoorOpen2");
			if(!playedOpen){
				OpenDoor.Play();
				playedOpen = true;
			}
			animatorLeftDoornowere.Play("DoorOpen");
			animatorRightDoornowere.Play("DoorOpen2");
		}
	}
}
