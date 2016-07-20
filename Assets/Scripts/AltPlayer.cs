using UnityEngine;
using System.Collections;

public class AltPlayer : MonoBehaviour {

	Vector2 moveVector ;
	Rigidbody2D myRigidBody ;
	// Use this for initialization

	public float playerSpeed = .1f;

	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> (); //good practice, declare variable above then use getcomponent in start

	}

	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		moveVector = new Vector2 (horizontal, vertical);

		//moveVector /= moveVector.magnitude; //manual normalization, /= is divide
		if (moveVector.magnitude > 1f) {
			moveVector = moveVector.normalized; //better way of normalization
		}
	}
	//fixed update is when Physics runs
	void FixedUpdate (){
		//myRigidBody.velocity = Vector2.zero ; //same as "new Vector2(0f,0f)"
		myRigidBody.velocity = moveVector * playerSpeed;


	}
}
