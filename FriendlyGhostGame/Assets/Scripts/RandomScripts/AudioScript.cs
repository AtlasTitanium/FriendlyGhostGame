using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

	public AudioClip audiocl;

	void Update() {
		if(Input.GetMouseButtonDown(0)) {
			AudioSource.PlayClipAtPoint(audiocl, transform.position);
		}
	}

}
