using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContr : MonoBehaviour {

	public Camera cam;
	public float moveSpeed = 3f;
	public Rigidbody rigidBody;
	private float verticalAxis;
	private float horizontalAxis;
	private float anglex;
	private float angley;
	private float mousex;
	private float mousey;
	private bool jump;
	public float jumpforce = 200;

	// Use this for initialization
	void Start () {
		rigidBody.GetComponent<Rigidbody>();
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {

		verticalAxis = Input.GetAxis("Vertical");
		horizontalAxis = Input.GetAxis("Horizontal");

		mousex = Input.GetAxis("Mouse X");
		mousey = Input.GetAxis("Mouse Y");

		anglex += mousex;
		angley += mousey;
		angley = Mathf.Clamp(angley, -80f, 80f);
		cam.transform.localRotation = Quaternion.Euler(-angley,anglex,0);

		jump = Input.GetKeyDown("space");
		if(jump){
			DoJump();
		}
	}

	private void FixedUpdate(){
		Vector3 forwardMovement = transform.forward * verticalAxis;
		Vector3 sideMovement = transform.right * horizontalAxis;
		rigidBody.MovePosition(rigidBody.position + (forwardMovement + sideMovement).normalized * moveSpeed * Time.deltaTime);
	}

	private void DoJump(){
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.up * -1f, out hit, 1.1f)){
			rigidBody.AddForce(transform.up * jumpforce);
		}
	}
}
