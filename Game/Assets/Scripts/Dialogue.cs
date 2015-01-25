using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour {

	Text dialogueBox;

	// Use this for 
	void Awake () {
		dialogueBox = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		dialogueBox.text = "Hello";

	

			StartConversation ();

	}

	void StartConversation(){
		bool talk = false;


		if (Input.GetKey ("d")) 
		{
			dialogueBox.text = "AAAAA";
			talk = true;

		}

		if (talk) 
		{
			if (Input.GetKey ("f")) 
			{
				dialogueBox.text = "BBBB";
			}
		}
		else 
		{
			if (Input.GetKey ("f")) 
			{
				dialogueBox.text = "nono";
			}
			
		}
	}
}
