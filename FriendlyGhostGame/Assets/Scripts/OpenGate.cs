using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenGate : MonoBehaviour {
	public Text infoText;
	public GameObject ThePlayer;
	public Collider triggerOpen;
	public Animator animatorLeftDoornowere;
	public Animator animatorRightDoornowere;

	public AudioSource fenceaudio;
	private bool onlyonce = true;

	private float transperency = 1f;
	private bool changeText = false;

	private bool onlyonce2 = true;

	void Start(){
		infoText.text = "Controls: \n |WASD| to move \n |Space| to jump \n |~| to open menu";
		StartCoroutine(WaitThisLong(10));
	}

	void Update(){
		if(changeText){
			transperency -= 0.1f;
			infoText.color = new Color(255,255,255,transperency);
		}

		if(transperency < 0.1f){
			if(onlyonce2){
				infoText.text = "";
				onlyonce2 = false;
			}
			changeText = false;
		}
	}
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

	IEnumerator WaitThisLong(int timewasted){
        yield return new WaitForSeconds(timewasted);
		changeText = true;
	}
}
