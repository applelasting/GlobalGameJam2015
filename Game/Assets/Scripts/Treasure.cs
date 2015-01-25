using UnityEngine;
using System.Collections;

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
		
	}
}
