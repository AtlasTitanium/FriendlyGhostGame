using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PureArea : MonoBehaviour { 
	public Camera player;
	public AudioSource PureAudiosrc;
	public AudioSource EvilAudiosrc;

	// Use this for initialization
	public Color colorEvil = Color.red;
    public Color colorPure = Color.blue;
	public Color colorBackground = Color.grey;

	bool startEvil;
	bool startPure;
	
	void Start()
    {
        player = GetComponent<Camera>();
        player.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
		if(startPure == true){
        	player.backgroundColor = colorPure;
		} else {
			player.backgroundColor = colorBackground;
		}

		if(startEvil == true){
        	player.backgroundColor = colorEvil;
		} else {
			player.backgroundColor = colorBackground;
		}
    }

	void OnTriggerEnter(){
		Debug.Log("Change background color to bright blue");
		PureAudiosrc.Play();
		startPure = true;
	}

	void OnTriggerExit(){
		Debug.Log("Change back background color");
		PureAudiosrc.Stop();
		startPure = false;
	}
}
