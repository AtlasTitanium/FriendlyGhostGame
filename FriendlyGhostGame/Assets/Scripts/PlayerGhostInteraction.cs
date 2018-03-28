using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGhostInteraction : MonoBehaviour {
	public GameObject TheGhost;
	public GameObject TheGhostwords;
	public GameObject TheGhostarea;
	private WhatSaisGhost TheGhostwordsscript;
	public GameObject PickupObject;
	public GameObject ThePlayer;
	private PickupPickup ThePlayerScript;

	public bool gotobject = false;

	public int ghostid;

	// Use this for initialization
	void Start () {
		gotobject = false;
		ThePlayerScript = ThePlayer.GetComponent<PickupPickup>();
		TheGhost.GetComponent<MoveAwayFromPlayer>().enabled = true;
		TheGhostwordsscript = TheGhostwords.GetComponent<WhatSaisGhost>();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(gotobject);
		//Debug.Log(PickupObjects[i]);
			if(ThePlayerScript.Inventory == PickupObject){
				gotobject = true;
				TheGhost.GetComponent<MoveAwayFromPlayer>().Hover();
				TheGhost.GetComponent<MoveAwayFromPlayer>().Objecthasbeenpickedup();
				//Debug.Log("Player has the object");
			} else {
				gotobject = false;
				TheGhost.GetComponent<MoveAwayFromPlayer>().enabled = true;
				TheGhostwords.GetComponent<WhatSaisGhost>().enabled = true;
				//Debug.Log("Player doesn't have the object");
			}
	}

	public void RemoveGhost(){
		TheGhostwordsscript.TheText.text = "";
		TheGhostarea.transform.localScale = new Vector3(2,2,2);
		TheGhost.GetComponent<MoveAwayFromPlayer>().GhostGoesAway();
		TheGhostwords.GetComponent<WhatSaisGhost>().GhostGoesAway();
		ThePlayer.GetComponent<PickupPickup>().NewGhost();
	}

	public void NoMoreAnrgyGhosts(){
		Debug.Log("YAY!!!! You WON");
	}
}
