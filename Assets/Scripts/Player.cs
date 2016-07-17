using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// reset velocity every frame
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);

		// press the up arrow to apply upward force
		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, 100f) * Time.deltaTime;
		}

		// press left arrow to apply left arrow force
		if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (-100f, 0f) * Time.deltaTime;
		}

		// press down arrow to apply downward force
		if (Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, -100f) * Time.deltaTime;
		}

		// press right arrow to apply rightward force
		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (100f, 0f) * Time.deltaTime;
		}
	}
}
