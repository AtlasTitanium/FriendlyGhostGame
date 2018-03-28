using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour {

	public Object NextScene;
	public void ChangeScene(){
		Application.LoadLevel(1);
	}
}
