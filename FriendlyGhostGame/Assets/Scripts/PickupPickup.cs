using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPickup : MonoBehaviour {
	public GameObject Inventory;

	public GameObject Pickups;

	public GameObject fpsCam;
	public GameObject[] Ghosts;
	public GameObject CurrentGhost;
	private PlayerGhostInteraction GhostsScript;

	public float range;
	public float Itemspeed;
	private bool moveItem = false;
	private int theItem;
	private Vector3 playerpickup;
	public int theghostid;
	private int amout;

	void Start () {
		CurrentGhost = Ghosts[0];
		GhostsScript = CurrentGhost.GetComponent<PlayerGhostInteraction>();
		Pickups = GameObject.FindWithTag("PickupObject");
		//Debug.Log("There are " + Pickups.Length + " pickups in this scene");
	}
	
	void Update () {
		GhostsScript = CurrentGhost.GetComponent<PlayerGhostInteraction>();
		playerpickup = new Vector3(transform.position.x,transform.position.y - 1f,transform.position.z);
		if(Input.GetMouseButtonDown(1)){
			DOINGIT();
		}

		if(moveItem){
			Pickups.transform.localScale -= new Vector3((Itemspeed/1.5f) * Time.deltaTime,(Itemspeed/1.5f) * Time.deltaTime,(Itemspeed/1.5f) * Time.deltaTime);
			Pickups.transform.position = Vector3.MoveTowards(Pickups.transform.position, playerpickup, Itemspeed * Time.deltaTime);
			if(Pickups.transform.localScale.y < 0){
				Inventory = Pickups;
				Pickups.SetActive(false);
				Pickups = null;
				//for(int i = 0; i < Pickups.Length; i++){
					//Pickups[i] = Pickups[i+1];
				//}
				theItem = -1;
				moveItem = false;
			}
		}
		/*
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, out hit)){
			if(hit.collider == Pickups[Pickups.Length-1]){
				Debug.Log("you're looking at the pickup object");
			}
			print("There is something in front of the object!");
		}
		*/
	}

	public void DOINGIT() {
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range/2, 1 << LayerMask.NameToLayer("Pickups"))){
			//Debug.Log(hit.transform.name);
			if(hit.transform == Pickups.transform){
				Pickups.GetComponent<Collider>().isTrigger = true;
				//Debug.Log(transform.position);
				//Debug.Log(Pickups[i].transform.position);
				//Debug.Log("move");
				moveItem = true;
			}
		}

		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range, 1 << LayerMask.NameToLayer("Invisible"))){
			if(GhostsScript.gotobject){
				//Debug.Log(hit.transform.name);
				GhostsScript.RemoveGhost();
			}
			//if(hit.transform == Pickups[0].transform){}
		}
	}

	public void NewGhost(){
		amout += 1;
		if(amout == Ghosts.Length){
			CurrentGhost.GetComponent<PlayerGhostInteraction>().NoMoreAnrgyGhosts();
		} else{
			CurrentGhost = Ghosts[amout];
		}
		Inventory.tag = "Finish";
		Inventory = null;
		Pickups = GameObject.FindWithTag("PickupObject");
	}
}
