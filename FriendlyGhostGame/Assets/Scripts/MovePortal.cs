using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePortal : MonoBehaviour {

	void Update(){
		if(Input.GetKeyDown("r")){
			transform.position = new Vector3(Random.Range(100,300), 0, Random.Range(100,300));
		}
	}
}
