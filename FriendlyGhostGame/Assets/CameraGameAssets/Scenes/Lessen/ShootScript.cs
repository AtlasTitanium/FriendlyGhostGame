using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

	public GameObject prefab;
	public Transform ShootPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			RaycastHit hit;
			if(Physics.Raycast(ShootPoint.position, ShootPoint.forward, out hit, 10f)){
				Instantiate(prefab, hit.point, ShootPoint.rotation);
			}
		}
	}
}
