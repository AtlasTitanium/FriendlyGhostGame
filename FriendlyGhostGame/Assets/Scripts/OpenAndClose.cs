using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenAndClose : MonoBehaviour {
	public Text InfoText;
	public GameObject endscreen;
	public GameObject managerOfSound;
	public GameObject ThePlayer;
	public GameObject ThePortalCamera;
	public GameObject thePlayerMusic;
	public Collider triggerOpen;
	public Collider triggerClose;

	public Collider triggerCloseEnd;

	//public Animator animatorLeftDoor;
	//public Animator animatorRightDoor;
	public GameObject SoundManager;
	public AudioSource OpenDoor;
	public AudioSource ShutDoor;

	public AudioSource OpenDoorEnd;

	public AudioSource ShutDoorEnd;

	public Animator animatorLeftDoornowere;
	public Animator animatorRightDoornowere;

	public Animator animatorLeftDoornowereEnd;
	public Animator animatorRightDoornowereEnd;

	public GameObject animatorLeftDoornowereEnd1;
	public GameObject animatorRightDoornowereEnd1;

	private bool playedOpen = false;
	private bool playedClose = false;
	private bool playedCloseEnd = false;

	public bool finishedGame = false;

	private float transperency = 1f;
	private bool changeText = false;
	private bool ChangeBack = false;
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Text goes away is: " + changeText);
		Debug.Log("Text Comes in is: " + ChangeBack);
		if(finishedGame){
			ChangeBack = true;
			InfoText.text = "The door downstairs opened";
			ThePlayer.GetComponent<Camera>().backgroundColor = new Color(212,212,212);
			ThePortalCamera.GetComponent<Camera>().backgroundColor = new Color(212,212,212);
			SoundManager.GetComponent<SoundManager>().PlayEnd();
			animatorLeftDoornowereEnd.Play("DoorOpen1");
			animatorRightDoornowereEnd.Play("DoorOpen3");
			animatorLeftDoornowereEnd1.SetActive(false);
			animatorRightDoornowereEnd1.SetActive(false);
			OpenDoorEnd.Play();
			finishedGame = false;
		}
		if(ChangeBack){
			transperency += 0.1f;
		}
		if(changeText){
			transperency -= 0.1f;
			if(transperency < 0.1f){
				InfoText.text = "";
				changeText = false;
			}
		}
		InfoText.color = new Color(255,255,255,transperency); 
	}

	void OnTriggerEnter(Collider other){
		if(other == triggerClose){
			InfoText.text = "Find the Ghosts their desired objects \n \n |Q| to get ghostcamera \n |Tab| to get flashlight";
			StartCoroutine(WaitThisLong(6));
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

		if(other == triggerCloseEnd){
			new Color(212,212,212);
			RenderSettings.fog = false;
			RenderSettings.ambientSkyColor = new Color(1,1,1);
			ThePlayer.GetComponent<Tablet>().enabled = true;
			thePlayerMusic.GetComponent<SoundManager>().playerisinside = true;
			//animatorLeftDoor.Play("DoorClose");
			//animatorRightDoor.Play("DoorClose2");
			if(!playedCloseEnd){
				InfoText.text = "";
				endscreen.SetActive(true);
				ShutDoorEnd.Play();
				playedCloseEnd = true;
				managerOfSound.GetComponent<SoundManager>().playerisinside = false;
			}
			animatorLeftDoornowereEnd.Play("DoorClose");
			animatorRightDoornowereEnd.Play("DoorClose2");
		}
	}

	IEnumerator WaitThisLong(int timewasted){
		ChangeBack = true;
        yield return new WaitForSeconds(timewasted);
		ChangeBack = false;
		changeText = true;
	}
}
