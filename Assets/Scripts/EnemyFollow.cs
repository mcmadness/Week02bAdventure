using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour {
	public Transform PlayerLocation ;
	public float chaseVelocity = 2f ;
	private float huntThePlayer = 0f;
	private float distToPlayer ;

	
	// Update is called once per frame
	void Update () {
		distToPlayer = Vector2.Distance(transform.position, PlayerLocation.position) ; //finding out how far away the player is,
		//originally I was thinking there'd be a limited range where you'd be hunted but I later decided continual hunt would be more exciting (hence huntThePlayer = 0)
	
		if (distToPlayer >= huntThePlayer ){
			transform.position = Vector2.MoveTowards (transform.position, PlayerLocation.position, chaseVelocity * Time.deltaTime); //changes the enemies position (transform) based on the player's location
		}
	
	}
}
