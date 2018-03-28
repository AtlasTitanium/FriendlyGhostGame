using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilArea : MonoBehaviour {

	public Camera player;
	public AudioSource audiosrc;
	// Use this for initialization
	public Color color1 = Color.red;
    public Color color2 = Color.blue;

	bool startTrip;

    void Start()
    {
        player = GetComponent<Camera>();
        player.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
		if(startTrip == true){
        	player.backgroundColor = color1;
		} else {
			player.backgroundColor = color2;
		}
    }

	private void OnTriggerEnter(){
		Debug.Log("Change background color to DarkRed");
		audiosrc.Play();
		startTrip = true;
	}

	private void OnTriggerExit(){
		Debug.Log("Change back background color");
		audiosrc.Stop();
		startTrip = false;
	}

	
}
