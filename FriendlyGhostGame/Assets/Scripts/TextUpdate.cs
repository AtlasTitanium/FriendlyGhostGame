using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextUpdate : MonoBehaviour {
	public GameObject button;
	public Text displayedText;
	public Text inputText;
	public float speed;
	private int i = -1;
	private bool go = false;
	private bool boi = true;
	void Update(){
		if(boi){
			StartCoroutine(Example());
		}
		char[] characters = inputText.text.ToCharArray();
		if(go){
			if (i == (characters.Length - 1)){
				button.SetActive(true);
			}
			i++;
			displayedText.text += characters[i];
			boi = true;
		}
	}
	IEnumerator Example()
    {
		boi = false;
		go = false;
        yield return new WaitForSeconds(speed);
		go = true;
    }
}

		/*
		if(!done){
			displayedText.text = Typewrite(inputText.text);
		} else {
			if(!changed){
				displayedText.text = italicText.text;
				changed = true;
			} else{
				button.SetActive(true);
			}
		}
	}

	private string Typewrite(string text){
		i++;
		char[] characters = text.ToCharArray();
		outputString = outputString + characters[i].ToString();
		if (i == (characters.Length - 1)){
			done = true;
		}
		return outputString;
	}
	*/
