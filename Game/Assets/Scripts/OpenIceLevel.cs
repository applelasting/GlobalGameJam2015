using UnityEngine;
using System.Collections;

public class OpenIceLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") 
		{
			Debug.Log ("Player has come");

			if(this.tag == "IceLevel"){
				Debug.Log ("IceLevelInitiated");
				Application.LoadLevel("IceLevel");
			}

			if(this.tag == "BoxLevel"){
				Debug.Log ("BoxLevel");
				Application.LoadLevel("JennyScene");

			}

			if(this.tag == "MountainLevel"){
				Debug.Log ("MountainLevel");
				Application.LoadLevel("JennyScene");

			}

			if(this.tag == "DoorLevel"){
				Debug.Log ("DoorLevel");
				Application.LoadLevel("AnswerInput");

			}
			//Destroy (this.gameObject, (float) 0.25);
			
		}
		MainCharacter.score += 10000;
		
	}
}
