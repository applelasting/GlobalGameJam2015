using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {

	}

    void FixedUpdate()
    {
        GameObject penguin = GameObject.Find("penguin");
        Vector3 fishPosition = transform.position;
        Vector3 penguinPosition = penguin.rigidbody2D.position;
        float distanceBetweenFishAndPenguin = Mathf.Sqrt(Mathf.Pow((penguinPosition.x - fishPosition.x), 2) + Mathf.Pow((penguinPosition.y - fishPosition.y), 2));

        if (distanceBetweenFishAndPenguin < 10)
        {
            // penguin is too close, move away from penguin
            Vector2 penguinVelocity = penguin.rigidbody2D.velocity;
            rigidbody2D.AddForce(20*penguinVelocity);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "penguin")
        {
            // update score
            FishScore.updateScore();
            Destroy(this.gameObject);
        }
    }
}
