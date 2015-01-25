using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

	Text TextScore;
//	int DisplayScore; 
	// Get the text Component
	void Awake () {

		TextScore = GetComponent<Text> ();
		
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		MainCharacter.score += 1;
		Debug.Log (MainCharacter.score);

		if (TextScore) 
		{
			//Debug (TextScore.text);
		}

		if (MainCharacter.score % 50 == 0)
		{
			TextScore.text = "Score: " + MainCharacter.score;
		}
		//MainCharacter.score += 1;
//		Debug.Log (MainCharacter.score);


		
	}


}
