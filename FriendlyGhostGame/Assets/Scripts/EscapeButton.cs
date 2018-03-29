using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeButton : MonoBehaviour {
	public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;
	public GameObject UI;
	public Button ResetButton;
	public Button EscapaButton;
	public bool state = false;
	CursorLockMode wantedMode;
	void Start () {
		ResetButton.onClick.AddListener(Reset);
		EscapaButton.onClick.AddListener(Escape);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.BackQuote)){
			Cursor.lockState = wantedMode = CursorLockMode.None;
			state = !state;
			controller.enabled = !state;
			Cursor.visible = state;
		}
		UI.SetActive(state);
	}

	void Reset(){
		Application.LoadLevel(0);
	}
	void Escape(){
		Application.Quit();
	}
    void SetCursorState()
    {
        //Cursor.lockState = wantedMode;
    }

	
}
