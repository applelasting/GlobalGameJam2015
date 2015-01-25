using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckName : MonoBehaviour {

	bool winner = false;
	// Update is called once per frame
	void Update () {
		//InputField text = GetComponent<InputField> ();
		//Debug.Log (text.text);
		if (winner) {
			Application.LoadLevel("Win");		
		}
	}

	void answerCheck(string input){
		if (input.ToLower() == "Jack William Frost"){
			Debug.Log ("Win the Game");
		}
	}

	[SerializeField]
	private InputField nameInputField = null; // Assign in editor
	
	private void Start()
	{
		// Add listener to catch the submit
		InputField.SubmitEvent submitEvent = new InputField.SubmitEvent();
		submitEvent.AddListener(SubmitName);
		nameInputField.onEndEdit = submitEvent;
		
		// Add validation
		//nameInputField.characterValidation = InputField.CharacterValidation.Alphanumeric;
		
	}
	
	private void SubmitName(string name)
	{
		//What to do with the value from input field
		Debug.Log (name);
		if (name == "Jack"){
			winner = true;
			Debug.Log (winner);

		}
	}
}
