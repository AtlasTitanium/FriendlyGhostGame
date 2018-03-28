using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PICKUP : MonoBehaviour {

	public GameObject cam;
	public GameObject pickup;

	public float range = 4;

	public LayerMask layerMask;

	public Vector3 offset = new Vector3(0, 1.2f, -1f);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1)){
			if(pickup == null){
				RaycastHit hit;
				if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range, layerMask)){
					pickup = hit.collider.gameObject;
					pickup.GetComponent<Rigidbody>().isKinematic = true;
				}
			} else {
				pickup.GetComponent<Rigidbody>().isKinematic = false;
				pickup = null;
			}
		}

		if(pickup != null){
			pickup.transform.position = cam.transform.position + cam.transform.forward *offset.z + cam.transform.up * offset.y;
			pickup.transform.SetParent(this.transform);
		}
		/*
		if(Input.GetKeyDown(KeyCode.F)){

		}
		*/
	}
}
