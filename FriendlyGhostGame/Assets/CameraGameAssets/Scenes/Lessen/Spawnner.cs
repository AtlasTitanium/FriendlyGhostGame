using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour {

	public GameObject prefab;
	// Use this for initialization
	void Start () {
		for(int i=0 ; i < 3; i++){
			Instantiate(prefab, new Vector3(2,i,2), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
