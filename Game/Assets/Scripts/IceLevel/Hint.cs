using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hint : MonoBehaviour {

    static Text hintText;

	// Use this for initialization
	void Start () {
	    hintText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void displayHint()
    {
        hintText.text = "Hint: Frost is forming on the ground.";
    }
}
