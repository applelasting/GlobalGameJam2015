using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {

	public static int score;
	//public static string name = "Jo";

	// Use this for initialization
	void Start () {
		score = 10;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (score);
		//score ++;
	}

    void FixedUpdate()
    {
        float positionX = transform.position.x;
        float positionY = transform.position.y;
        float movementSpeed = (float)0.4;
		float boostSpeed = (float)1.5;

        // Move right
        if (Input.GetKey("d"))
        {

            transform.position = new Vector3(positionX + movementSpeed, positionY, 0);
        }

        // Move left
        if (Input.GetKey("a"))
        {
            transform.position = new Vector3(positionX - movementSpeed, positionY, 0);
        }

        // Move up
        if (Input.GetKey("w"))
        {
            transform.position = new Vector3(positionX, positionY + movementSpeed, 0);
			if(Input.GetKey("w")){
				transform.position = new Vector3(positionX, positionY + boostSpeed, 0);

			}
        }

        // Move down
        if (Input.GetKey("s"))
        {
            transform.position = new Vector3(positionX, positionY - movementSpeed, 0);
        }
    }
}
