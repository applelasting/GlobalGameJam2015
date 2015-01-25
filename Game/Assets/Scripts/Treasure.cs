using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Treasure : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MainCharacter.score ++;
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") 
		{
			Debug.Log ("Player has come");
			Destroy (this.gameObject, (float) 0.25);

		}
		MainCharacter.score += 10000;


		UpdateInstruction ();
		
	}

	void UpdateInstruction(){
		GameObject instructions = GameObject.Find ("Instruction");
		Text insText = instructions.GetComponent<Text> ();
		insText.text = "Clue: Jack the Pirate \n Now Return to Map \n Nothing left to see!";

	}
}
