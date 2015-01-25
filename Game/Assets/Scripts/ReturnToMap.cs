using UnityEngine;
using System.Collections;

public class ReturnToMap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Update is called once per frame
	public void change (string scenename) {
		Application.LoadLevel (scenename);
		
	}
}
