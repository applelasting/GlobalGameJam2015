using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

	Text TextScore;
//	int DisplayScore; 

	// Use this for initialization
	void Start () {
		Debug.Log (MainCharacter.score);
	}
	
	// Update is called once per frame
	void Update () {
		if (MainCharacter.score % 50 == 0)
		{
			TextScore.text = "Score: " + MainCharacter.score;
		}
		MainCharacter.score += 1;
//		Debug.Log (MainCharacter.score);


		
	}

	// Get the text Component
	void Awake () {
		TextScore = GetComponent<Text> ();

	}
}
