using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

	Text TextScore;
	int DisplayScore; 

	// Use this for initialization
	void Start () {
		DisplayScore = MainCharacter.score;
		Debug.Log (DisplayScore);
	}
	
	// Update is called once per frame
	void Update () {
		TextScore.text = "Score: " + DisplayScore;
	
	}

	// Get the text Component
	void Awake () {
		TextScore = GetComponent<Text> ();

	}
}
